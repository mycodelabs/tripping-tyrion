using mars_rovers_project.shared;

namespace mars_rovers_project.plateau.contracts
{
    public interface IPlateauFactory
    {
        Plateau.Plateau create_boundary(Coordinates coordinates);
    }
}