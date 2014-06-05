namespace mars_rovers_project.rover_domain.contracts
{
    public interface IControlRover
    {
        Rover control_using(string instructions);
    }
}