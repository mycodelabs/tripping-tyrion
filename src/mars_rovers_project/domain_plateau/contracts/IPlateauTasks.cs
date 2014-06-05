using mars_rovers_project.shared;

namespace mars_rovers_project.domain_plateau.contracts
{
    public interface IPlateauTasks
    {
        Plateau create(Coordinates coordinates);
    }
}