using mars_rovers_project.rover_domain;
using NUnit.Framework;

namespace mars_rovers_project.tests.Rovers
{
    [TestFixture]
    public class heading_concern
    {
        [Test]
        public void Should_head_north_given_character_n()
        {
            const char direction = 'n';
            var result = Heading.Get(direction);
            Assert.AreEqual(result, Heading.north);
        }

        [Test]
        public void should_head_south_given_character_s()
        {
            const char direction = 's';
            var result = Heading.Get(direction);
            Assert.AreEqual(result, Heading.south);
        }

        [Test]
        public void should_head_south_given_character_e() {
            const char direction = 'e';
            var result = Heading.Get(direction);
            Assert.AreEqual(result, Heading.east);
        }

        [Test]
        public void should_head_south_given_character_w() {
            const char direction = 'w';
            var result = Heading.Get(direction);
            Assert.AreEqual(result, Heading.west);
        }
    }
}