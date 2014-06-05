using mars_rovers_project.rover_domain.contracts;

namespace mars_rovers_project.rover_domain
{
    public class RoverTasks : IRoverTasks
    {
        private readonly IRoverMove rover_move;

        public RoverTasks(IRoverMove rover_move)
        {
            this.rover_move = rover_move;
        }

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
            rover.Heading.apply(rover_move, rover);
        }
    }
}