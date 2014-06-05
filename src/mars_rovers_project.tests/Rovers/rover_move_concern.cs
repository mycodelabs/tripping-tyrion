using NUnit.Framework;
using mars_rovers_project.rover_domain;
using mars_rovers_project.rover_domain.contracts;
using mars_rovers_project.shared;

namespace mars_rovers_project.tests.Rovers
{
    [TestFixture]
    public class rover_move_concern
    {
        private RoverMove rover_move;
        private Rover rover;
        private Coordinates coordinates;

        [SetUp]
        public void setup()
        {
            coordinates = new Coordinates { point_x = 1, point_y = 1 };
            rover = new Rover { Coordinates = coordinates, Heading = Compass.north };
            rover_move = new RoverMove();
        }

        [Test]
        public void should_move_rover_a_step_towards_north()
        {
            rover_move.head_north(ref rover);
            Assert.AreEqual(2, rover.Coordinates.point_y);
        }

        [Test]
        public void should_move_rover_towards_south()
        {
            rover_move.head_south(ref rover);
            Assert.AreEqual(0, rover.Coordinates.point_y);
        }

        [Test]
        public void should_move_rover_towards_east()
        {
            rover_move.head_east(ref rover);
            Assert.AreEqual(2, rover.Coordinates.point_x);
        }

        [Test]
        public void should_move_rover_towards_west()
        {
            rover_move.head_west(ref rover);
            Assert.AreEqual(0, rover.Coordinates.point_x);
        }
    }
}
