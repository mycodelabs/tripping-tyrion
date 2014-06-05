namespace mars_rovers_project.domain_rover.contracts
{
    public interface IControlRover
    {
        Rover move_using(string instructions);
    }
}