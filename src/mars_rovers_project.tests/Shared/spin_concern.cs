using mars_rovers_project.shared;
using NUnit.Framework;

namespace mars_rovers_project.tests.Shared
{
    [TestFixture]
    public class spin_concern
    {
        [Test]
        public void Should_spin_left_provided_L()
        {
            var result = Spin.Get('L');
            Assert.AreEqual(result, Spin.left);
        }

        [Test]
        public void Should_spin_right_provided_R()
        {
            var result = Spin.Get('R');
            Assert.AreEqual(result, Spin.right);
        }

        [Test]
        public void Should_move_provided_M()
        {
            var result = Spin.Get('M');
            Assert.AreEqual(result, Spin.move);
        }
    }
}