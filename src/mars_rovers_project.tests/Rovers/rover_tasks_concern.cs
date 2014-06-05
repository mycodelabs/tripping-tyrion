using Rhino.Mocks;
using mars_rovers_project.common;
using mars_rovers_project.rover_domain;
using NUnit.Framework;
using mars_rovers_project.rover_domain.contracts;

namespace mars_rovers_project.tests.Rovers
{
    [TestFixture]
    public class rover_tasks_concern
    {
        private Rover rover;
        private RoverTasks rover_tasks;
        private IRoverMove rover_move;

        [SetUp]
        public void setup()
        {
            rover_move = MockRepository.GenerateMock<IRoverMove>();
            rover = Instance.Create<Rover>();
            rover.Heading = Compass.north;
            rover_tasks = new RoverTasks(rover_move);
        }

        [Test]
        public void Should_spin_left()
        {
            rover_tasks.spin_left(ref rover);
            Assert.AreEqual(rover.Heading, Compass.west);
        }

        [Test]
        public void Should_spin_right()
        {
            rover_tasks.spin_right(ref rover);
            Assert.AreEqual(rover.Heading, Compass.east);
        }
    }
}