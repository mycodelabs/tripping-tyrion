using mars_rovers_project.domain_plateau;

namespace mars_rovers_project.domain_rover.contracts
{
    public delegate void IValidateRoverPosition(Rover rover, Plateau plateau);
}