namespace mars_rovers_project.domain_rover.contracts
{
    public interface IRoverTasks
    {
        void spin_left(ref Rover rover);
        void spin_right(ref Rover rover);
        void move_a_step(ref Rover rover);
    }
}