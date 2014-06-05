using System;
using mars_rovers_project.rover_domain.contracts;

namespace mars_rovers_project.rover_domain
{
    public class RoverTasks : IRoverTasks
    {
        public void spin_left(ref Rover rover)
        {
            rover.Heading = Compass.Get(rover.Heading.left_direction);
        }

        public void spin_right(ref Rover rover)
        {
            rover.Heading = Compass.Get(rover.Heading.right_direction);
        }

        public void move_a_step(ref Rover rover)
        {
            throw new NotImplementedException();
        }
    }
}