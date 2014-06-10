using mars_rovers_project.shared;

namespace mars_rovers_project.domain_rover
{
    public interface IRoverCoordinates
    {
        IRoverInPlateau at(Coordinates coordinates);
    }
}