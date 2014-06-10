using System;
using System.Collections.Generic;
using System.Data;
using NUnit.Framework;
using Rhino.Mocks;
using mars_rovers_project.container.Basic;

namespace mars_rovers_project.tests.Container
{
    [TestFixture]
    public class dependency_factories_specs
    {
        [TestFixture]
        public class when_finding_the_factory_for_a_dependency
        {
            private ICreateOneDependency result;
            private ICreateOneDependency factory;
            private IDictionary<Type, ICreateOneDependency> all_the_factories;
            private Exception created_exception;
            private ICreateTheExceptionForAMissingDependencyFactory missing_dependency_error_handler;
            private IFindAFactoryForADependency factories;

            [SetUp]
            public void setup()
            {
                factory = MockRepository.GenerateMock<ICreateOneDependency>();
                missing_dependency_error_handler = MockRepository.GenerateMock<ICreateTheExceptionForAMissingDependencyFactory>();
                all_the_factories = new Dictionary<Type, ICreateOneDependency>();
            }

            [Test]
            public void it_has_the_factory_should_return_the_factory()
            {
                all_the_factories[typeof (IStub)] = factory; 
                factories = new DependecyFactories(all_the_factories, missing_dependency_error_handler);
                result = factories.get_factory_to_create(typeof (IStub));
                Assert.AreEqual(result, factory);
            }

            [Test]
            [ExpectedException(typeof(Exception))]
            public void it_does_not_have_the_factory_should_throw_an_exception()
            {
                 created_exception = new Exception();
                missing_dependency_error_handler = x =>
                    {
                        Assert.AreEqual(x, typeof(IDbConnection));
                        return created_exception;
                    };
                factories = new DependecyFactories(all_the_factories, missing_dependency_error_handler);
                factories.get_factory_to_create(typeof (IDbConnection));
            }
        }
    }

    public interface IStub
    {
    }
}
