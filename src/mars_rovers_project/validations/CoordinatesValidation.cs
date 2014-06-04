using System;
using mars_rovers_project.plateau.contracts;

namespace mars_rovers_project.validations
{
    public class CoordinatesValidation
    {
        public static IValidateCoordinates Validate = (coordinates) =>
            {
                if (coordinates.point_x < 0 || coordinates.point_y < 0)
                {
                    throw new FormatException("Coordinates should be positive integers");
                }
            };
    }
}
