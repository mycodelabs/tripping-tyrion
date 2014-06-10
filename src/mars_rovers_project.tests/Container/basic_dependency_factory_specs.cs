using System;
using NUnit.Framework;
using mars_rovers_project.container.Basic;

namespace mars_rovers_project.tests.Container
{
    [TestFixture]
    public class basic_dependency_factory_specs
    {
        [TestFixture]
        public class when_creating_a_dependency
        {
            private object created;
            private AnonymousDependencyFactory factory;
            private object result;

            public void it_should_return_the_depedency_by_its_provided_delegate()
            {
                created = new object();
                Func<object> objectDelegate = () => created;

                factory = new AnonymousDependencyFactory(objectDelegate);
                result = factory.create();

                Assert.AreEqual(result, 42);
            }
        }
    }
}
