using mars_rovers_project.rover_domain;
using NUnit.Framework;

namespace mars_rovers_project.tests.Rovers
{
    [TestFixture]
    public class compass_concern
    {
        [Test]
        public void Should_head_north_given_character_n()
        {
            const char direction = 'n';
            var result = Compass.Get(direction);
            Assert.AreEqual(result, Compass.north);
            Assert.AreEqual(result.left_direction, 'w');
            Assert.AreEqual(result.right_direction, 'e');
        }

        [Test]
        public void should_head_south_given_character_s()
        {
            const char direction = 's';
            var result = Compass.Get(direction);
            Assert.AreEqual(result, Compass.south);
            Assert.AreEqual(result.left_direction, 'e');
            Assert.AreEqual(result.right_direction, 'w');
        }

        [Test]
        public void should_head_south_given_character_e() {
            const char direction = 'e';
            var result = Compass.Get(direction);
            Assert.AreEqual(result, Compass.east);
            Assert.AreEqual(result.left_direction, 'n');
            Assert.AreEqual(result.right_direction, 's');
        }

        [Test]
        public void should_head_south_given_character_w() {
            const char direction = 'w';
            var result = Compass.Get(direction);
            Assert.AreEqual(result, Compass.west);
            Assert.AreEqual(result.left_direction, 's');
            Assert.AreEqual(result.right_direction, 'n');
        }
    }
}