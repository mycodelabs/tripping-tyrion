using System;
using mars_rovers_project.common;
using mars_rovers_project.rover_domain;
using NUnit.Framework;

namespace mars_rovers_project.tests.Rovers
{
    [TestFixture]
    public class rover_tasks_concern
    {
        private Rover rover;
        private RoverTasks rover_tasks;

        [SetUp]
        public void setup()
        {
            rover = Instance.Create<Rover>();
            rover.Heading = Compass.north;
            rover_tasks = new RoverTasks();
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

        [Test]
        [ExpectedException(typeof(NotImplementedException))]
        public void Should_move_a_step()
        {
            rover_tasks.move_a_step(ref rover);
            
        }
    }
}