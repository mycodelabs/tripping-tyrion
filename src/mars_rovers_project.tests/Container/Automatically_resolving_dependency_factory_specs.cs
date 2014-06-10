using System.Data;
using System.Reflection;
using NUnit.Framework;
using Rhino.Mocks;
using mars_rovers_project.container;

namespace mars_rovers_project.tests.Container
{
    public class Automatically_resolving_dependency_factory_specs
    {
        [TestFixture]
        public class when_creating_a_dependency
        {
            private AutomaticallyResolvingDependencyFactory dependency_resolver;
            private TypeWithLotsOfDependencies result;
            private IDbConnection connection;
            private IDataReader reader;
            private IPickAConstructor pick_a_constructor;
            private ConstructorInfo greediest_constructor;
            private IFetchDependencies the_container;

            [SetUp]
            public void SetUp()
            {
                connection = MockRepository.GenerateMock<IDbConnection>();
                reader = MockRepository.GenerateMock<IDataReader>();
                pick_a_constructor = MockRepository.GenerateMock<IPickAConstructor>();
                the_container = MockRepository.GenerateMock<IFetchDependencies>();
            }

            [Test]
            public void it_should_create_the_dependency_with_all_of_its_dependencies_resolved_correctly()
            {
                greediest_constructor =
                    ObjectFactory.expression.to_target<TypeWithLotsOfDependencies>().
                                                                    ctor_pointed_at_by(() => new TypeWithLotsOfDependencies(null,null));
                pick_a_constructor = (type) =>
                    {
                        Assert.AreEqual(type, typeof (TypeWithLotsOfDependencies));
                        return greediest_constructor;
                    };

                the_container.Stub(x => x.a(typeof (IDbConnection))).Return(connection);
                the_container.Stub(x => x.a(typeof (IDataReader))).Return(reader);

                dependency_resolver = new AutomaticallyResolvingDependencyFactory(typeof(TypeWithLotsOfDependencies), pick_a_constructor, the_container);
                result = (TypeWithLotsOfDependencies) dependency_resolver.create();

                Assert.IsInstanceOf<TypeWithLotsOfDependencies>(result);
                Assert.AreEqual(result.connection, connection);
                Assert.AreEqual(result.reader, reader);
            }
        }

        public class TypeWithLotsOfDependencies
        {
            public IDbConnection connection;
            public IDataReader reader;

            public TypeWithLotsOfDependencies(IDbConnection connection, IDataReader reader)
            {
                this.connection = connection;
                this.reader = reader;
            }

            public TypeWithLotsOfDependencies(IDbConnection connection)
            {
                this.connection = connection;
            }

            public TypeWithLotsOfDependencies(IDataReader reader)
            {
                this.reader = reader;
            }
        }
    }
}