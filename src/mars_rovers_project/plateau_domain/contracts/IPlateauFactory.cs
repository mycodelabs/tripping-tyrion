using mars_rovers_project.shared;

namespace mars_rovers_project.plateau_domain.contracts
{
    public interface IPlateauFactory
    {
        Plateau create_boundary(Coordinates coordinates);
    }
}