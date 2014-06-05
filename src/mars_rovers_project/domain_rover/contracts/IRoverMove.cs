namespace mars_rovers_project.domain_rover.contracts
{
    public interface IRoverMove
    {
        void head_north(ref Rover rover);
        void head_south(ref Rover rover);
        void head_west(ref Rover rover);
        void head_east(ref Rover rover);
    }
}
