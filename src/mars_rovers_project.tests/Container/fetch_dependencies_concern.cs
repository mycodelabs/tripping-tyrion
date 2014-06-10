using System;
using System.Data;
using NUnit.Framework;
using Rhino.Mocks;
using mars_rovers_project.container.Basic;

namespace mars_rovers_project.tests.Container
{
    [TestFixture]
    public class when_fetching_a_dependency_concern
    {
        private DependencyContainer dependency_container;
        private IDbConnection result;
        private IDbConnection the_connection;
        private IFindAFactoryForADependency factories;
        private ICreateOneDependency the_factory_that_can_create_the_dependency;
        private Exception third_party_exception;
        private Exception wrapped_exception;
        private ICreateErrorsFromFactoryContainerErrors error_handler;

        [SetUp]
        public void setup()
        {
            the_connection = MockRepository.GenerateMock<IDbConnection>();
            factories = MockRepository.GenerateMock<IFindAFactoryForADependency>();
            the_factory_that_can_create_the_dependency = MockRepository.GenerateMock<ICreateOneDependency>();

            factories.Stub(x => x.get_factory_to_create(typeof(IDbConnection))).Return(the_factory_that_can_create_the_dependency);
            error_handler = MockRepository.GenerateMock<ICreateErrorsFromFactoryContainerErrors>();
        }

        [Test]
        public void it_should_return_the_dependency_created_by_the_factory_for_that_dependency()
        {
            the_factory_that_can_create_the_dependency.Stub(x => x.create()).Return(the_connection);
            dependency_container = new DependencyContainer(factories, error_handler);
            result = dependency_container.a<IDbConnection>();
            Assert.AreEqual(result, the_connection);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void when_the_factory_that_creates_the_dependency_throws_a_dependency_creation_exception()
        {
            third_party_exception = new Exception();
            wrapped_exception = new Exception();

            error_handler = ((type, original_exception) =>
                {
                    Assert.AreEqual(type, typeof (IDbConnection));
                    Assert.AreEqual(original_exception, third_party_exception);
                    throw wrapped_exception;
                });

            the_factory_that_can_create_the_dependency.Stub(x => x.create()).Throw(third_party_exception);

            dependency_container = new DependencyContainer(factories, error_handler);
            dependency_container.a(typeof (IDbConnection));
        }
    }
}
