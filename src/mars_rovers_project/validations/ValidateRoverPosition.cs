using System;
using mars_rovers_project.rover_domain;

namespace mars_rovers_project.validations 
{
    public class ValidateRoverPosition
    {
        public static IValidateRoverPosition validate = (rover, plateau) =>
        {
            if (rover.Coordinates.point_x > plateau.coordinates.point_x || 
                rover.Coordinates.point_y > plateau.coordinates.point_y ||
                rover.Coordinates.point_x < 0 ||
                rover.Coordinates.point_y < 0)
                throw new ArgumentOutOfRangeException("rover is outside the bounds of plateau");
        };
    }
}
