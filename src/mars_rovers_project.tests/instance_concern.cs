using NUnit.Framework;
using mars_rovers_project.common;

namespace mars_rovers_project.tests
{
    [TestFixture]
    public class instance_concern
    {

        [Test]
        public void given_a_class_should_return_instance()
        {
            var result = Instance.Create<Test>();
            Assert.IsInstanceOf<Test>(result);
        }

        public class Test
        {
            
        }
    }
}
