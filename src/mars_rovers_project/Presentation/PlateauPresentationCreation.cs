using mars_rovers_project.Presentation.Contracts;
using mars_rovers_project.shared;

namespace mars_rovers_project.Presentation
{
    public class PlateauPresentationCreation
    {
        public static IPlateauPresentationCreation create_plateau = (coordinates, tasks) =>
            {
                var boundaries = coordinates().Split(' ');
                var point_x = int.Parse(boundaries[0]);
                var point_y = int.Parse(boundaries[1]);
                return tasks.create(new Coordinates {point_x = point_x, point_y = point_y});
            };
    }
}