using mars_rovers_project.common;
using mars_rovers_project.plateau.contracts;
using mars_rovers_project.shared;

namespace mars_rovers_project.plateau
{
    public class PlateauFactory : IPlateauFactory
    {
        public Plateau.Plateau create_boundary(Coordinates coordinates)
        {
            var plateau = Instance.Create<Plateau.Plateau>();
            plateau.coordinates.point_x = coordinates.point_x;
            plateau.coordinates.point_y = coordinates.point_y;
            return plateau;
        }
    }
}