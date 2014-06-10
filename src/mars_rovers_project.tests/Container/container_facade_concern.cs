using NUnit.Framework;
using Rhino.Mocks;
using mars_rovers_project.container;

namespace mars_rovers_project.tests.Container
{
    [TestFixture]
    public class container_facade_concern 
    {
        private IFetchDependencies result;
        private IFetchDependencies the_container;

        [Test]
        public void should_return_the_container_built_by_the_container_setup_process()
        {
            the_container = MockRepository.GenerateMock<IFetchDependencies>();
            ISetupTheContainer setup = () => the_container;
            Dependencies.container_factory =  setup;
            result = Dependencies.fetch;
            Assert.AreEqual(result, the_container);
        }
    }
}
