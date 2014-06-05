using System;
using mars_rovers_project.common;
using mars_rovers_project.plateau_domain;
using mars_rovers_project.plateau_domain.contracts;
using mars_rovers_project.rover_domain;
using mars_rovers_project.shared;
using NUnit.Framework;

namespace mars_rovers_project.tests.Rovers
{
    [TestFixture]
    public class rover_deploy_and_moves_concern
    {
        private Rover rover;
        private Rover result;
        private Plateau plateau;
        private Coordinates coordinates;
        private char direction;
        private IPlateauTasks plateau_tasks;
        private const string instructions = "LMLMLMLMM";

        [SetUp]
        public void setup()
        {
            rover = Instance.Create<Rover>();
            coordinates = new Coordinates { point_x = 3, point_y = 2 };
            plateau = new Plateau { coordinates = new Coordinates { point_x = 5, point_y = 5 } };
            direction = 'n';
        }

        [Test]
        public void Should_be_able_to_deploy_rover_at_given_coordinates()
        {          
            rover.deploy().at(coordinates);
            Assert.AreEqual(rover.Coordinates.point_x, coordinates.point_x);
            Assert.AreEqual(rover.Coordinates.point_y, coordinates.point_y);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void should_be_able_to_deploy_rover_at_given_coordinates_in_plateau()
        {
            plateau = new Plateau{ coordinates = new Coordinates{ point_x = 2, point_y = 2}};
            rover.deploy().at(coordinates).@in(plateau);
        }

        [Test]
        public void Should_be_able_deploy_robot_at_given_coordinates_in_plateau_facing_given_direction() 
        {
            rover.deploy().at(coordinates).@in(plateau).facing_towards(direction);
            Assert.AreEqual(rover.Coordinates.point_x, coordinates.point_x);
            Assert.AreEqual(rover.Coordinates.point_y, coordinates.point_y);
            Assert.AreEqual(rover.Heading, Compass.north);
        }

        [Test]
        public void Should_be_able_deploy_robot_at_given_coordinates_in_plateau_facing_given_direction_and_instruct()
        {
            result = rover.deploy().at(coordinates).@in(plateau).facing_towards(direction).move_using(instructions);
            Assert.AreEqual(3, result.Coordinates.point_x);
            Assert.AreEqual(3, result.Coordinates.point_y);
            Assert.AreEqual('n', result.Heading.Key);
        }
    }
}