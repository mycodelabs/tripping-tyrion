using mars_rovers_project.plateau_domain;
using mars_rovers_project.rover_domain.contracts;
using mars_rovers_project.validations;

namespace mars_rovers_project.rover_domain
{
    public class RoverInPlateau
    {
        private readonly Rover rover_to_deploy;
        private readonly IValidateRoverPosition validate_rover_position;

        public RoverInPlateau(Rover rover_to_deploy)
        {
            this.rover_to_deploy = rover_to_deploy;
            validate_rover_position = ValidateRoverPosition.validate;
        }

        public Direction @in(Plateau plateau_to_deploy)
        {
            validate_rover_position(rover_to_deploy, plateau_to_deploy);
            return new Direction(rover_to_deploy);
        }
    }
}