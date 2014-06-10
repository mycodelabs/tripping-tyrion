using mars_rovers_project.domain_rover.contracts;

namespace mars_rovers_project.domain_rover
{
    public class Direction : IDirection
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