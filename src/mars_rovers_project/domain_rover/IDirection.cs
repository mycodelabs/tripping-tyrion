using mars_rovers_project.domain_rover.contracts;

namespace mars_rovers_project.domain_rover
{
    public interface IDirection
    {
        IControlRover facing_towards(char direction);
    }
}