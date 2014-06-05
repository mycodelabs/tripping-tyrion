using mars_rovers_project.plateau_domain.contracts;
using mars_rovers_project.shared;
using mars_rovers_project.validations;

namespace mars_rovers_project.plateau_domain
{
    public class PlateauTasks : IPlateauTasks
    {
        private readonly IPlateauFactory plateau_factory;
        private readonly IValidateCoordinates validate_coordinates;

        public PlateauTasks(IPlateauFactory plateau_factory)
        {
            this.plateau_factory = plateau_factory;
            this.validate_coordinates = CoordinatesValidation.Validate;
        }

        public Plateau create(Coordinates coordinates)
        {
            validate_coordinates(coordinates);
            return plateau_factory.create_boundary(coordinates);
        }
    }
}