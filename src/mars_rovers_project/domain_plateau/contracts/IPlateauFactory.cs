using mars_rovers_project.shared;

namespace mars_rovers_project.domain_plateau.contracts
{
    public interface IPlateauFactory
    {
        Plateau create_boundary(Coordinates coordinates);
    }
}