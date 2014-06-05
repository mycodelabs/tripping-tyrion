using mars_rovers_project.plateau_domain;
using mars_rovers_project.validations;

namespace mars_rovers_project.rover_domain
{
    public class PlateauExtensionPoint
    {
        private readonly Rover rover_to_deploy;
        private readonly IValidateRoverPosition validate_rover_position;

        public PlateauExtensionPoint(Rover rover_to_deploy)
        {
            this.rover_to_deploy = rover_to_deploy;
            validate_rover_position = ValidateRoverPosition.validate;
        }

        public DirectionExtensionPoint @in(Plateau plateau_to_deploy)
        {
            validate_rover_position(rover_to_deploy, plateau_to_deploy);
            return new DirectionExtensionPoint(rover_to_deploy);
        }
    }
}