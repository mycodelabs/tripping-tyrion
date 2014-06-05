using mars_rovers_project.common;
using mars_rovers_project.domain_rover;
using mars_rovers_project.shared;
using NUnit.Framework;

namespace mars_rovers_project.tests.Rovers
{
    [TestFixture]
    public class rover_concern
    {
        private Rover rover;
        private Coordinates coordinates;

        [SetUp]
        public void setup()
        {
            rover = Instance.Create<Rover>();
            coordinates = new Coordinates { point_x = 1, point_y = 2 };
        }

        [Test]
        public void Should_be_able_to_create_a_rover()
        {
            var result = Instance.Create<Rover>();
            Assert.IsInstanceOf<Rover>(result);
        }

        [Test]
        public void Should_be_able_to_assign_heading_to_rover()
        {
            rover.Heading = Compass.north;
            Assert.AreEqual(rover.Heading, Compass.north);
        }

        [Test]
        public void Should_have_coordinates()
        {
            rover.Coordinates = coordinates;
            Assert.AreEqual(rover.Coordinates.point_x, coordinates.point_x);
            Assert.AreEqual(rover.Coordinates.point_y, coordinates.point_y);
        }
    }
}