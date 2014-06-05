namespace mars_rovers_project.rover_domain.contracts
{
    public interface IControlRover
    {
        Rover move_using(string instructions);
    }
}