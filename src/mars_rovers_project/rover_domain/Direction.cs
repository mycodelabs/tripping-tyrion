using mars_rovers_project.rover_domain.contracts;

namespace mars_rovers_project.rover_domain
{
    public class Direction
    {
        private readonly Rover rover;

        public Direction(Rover rover)
        {
            this.rover = rover;
        }

        public IControlRover facing_towards(char direction)
        {
            rover.Heading = Compass.Get(direction);
            return new ControlRover(rover);
        }
    }
}