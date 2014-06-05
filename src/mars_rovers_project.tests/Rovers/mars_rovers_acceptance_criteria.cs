using NUnit.Framework;
using mars_rovers_project.common;
using mars_rovers_project.plateau_domain;
using mars_rovers_project.rover_domain;
using mars_rovers_project.shared;

namespace mars_rovers_project.tests.Rovers
{
    [TestFixture]
    public class mars_rovers_acceptance_criteria
    {
        [TestFixture]
        public class given_the_first_rover_input_provided_in_the_problem
        {
            private Coordinates coordinates;
            private char direction;
            private string instructions;
            private Rover rover;
            private Plateau plateau;
            private Rover result;

            [SetUp]
            public void setup()
            {
                rover = Instance.Create<Rover>();
                plateau = new Plateau { coordinates = new Coordinates { point_x = 5, point_y = 5 } };
                coordinates = new Coordinates { point_x = 1, point_y = 2 };
                direction = 'n';
                instructions = "LMLMLMLMM";
                result = rover.deploy().at(coordinates).@in(plateau).facing_towards(direction).move_using(instructions);
            }

            [Test]
            public void point_x_of_the_current_position_of_rover()
            {
                Assert.AreEqual(1, result.Coordinates.point_x);
            }

            [Test]
            public void point_y_of_the_current_position_of_rover()
            {
                Assert.AreEqual(3, result.Coordinates.point_y);
            }

            [Test]
            public void direction_of_rover()
            {
                Assert.AreEqual('n', result.Heading.Key);
            }
        }

        [TestFixture]
        public class given_the_second_rover_input_provided_in_the_problem
        {
            private Coordinates coordinates;
            private char direction;
            private string instructions;
            private Rover rover;
            private Plateau plateau;
            private Rover result;

            [SetUp]
            public void setup()
            {
                rover = Instance.Create<Rover>();
                plateau = new Plateau { coordinates = new Coordinates { point_x = 5, point_y = 5 } };
                coordinates = new Coordinates { point_x = 3, point_y = 3 };
                direction = 'e';
                instructions = "MMRMMRMRRM";
                result = rover.deploy().at(coordinates).@in(plateau).facing_towards(direction).move_using(instructions);
            }

            [Test]
            public void  point_x_of_the_current_position_of_rover()
            {
                 Assert.AreEqual(5, result.Coordinates.point_x);
            }

            [Test]
            public void point_y_of_the_current_position_of_rover()
            {
                Assert.AreEqual(1, result.Coordinates.point_y);     
            }

            [Test]
            public void direction_of_rover()
            {
                Assert.AreEqual('e', result.Heading.Key);
            }
        }
    }
}