using mars_rovers_project.domain_plateau;
using mars_rovers_project.shared;

namespace mars_rovers_project.Presentation
{
    public interface IUserInteraction
    {
        string rover_instructions();
        void rover_positions(out Coordinates coordinates, out char direction);
        Plateau plateau_creation();
        void navigate_rover(Coordinates coordinates, Plateau plateau, char direction, string instructions);
    }
}