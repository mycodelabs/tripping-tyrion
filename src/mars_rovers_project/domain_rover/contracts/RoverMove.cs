namespace mars_rovers_project.domain_rover.contracts
{
    public class RoverMove : IRoverMove
    {
        public void head_north(ref Rover rover)
        {
            rover.Coordinates.point_y += 1;
        }

        public void head_south(ref Rover rover)
        {
            rover.Coordinates.point_y -= 1;
        }

        public void head_west(ref Rover rover)
        {
            rover.Coordinates.point_x -= 1;
        }

        public void head_east(ref Rover rover)
        {
            rover.Coordinates.point_x += 1;
        }
    }
}