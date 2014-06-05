using mars_rovers_project.shared;

namespace mars_rovers_project.rover_domain
{
    public class CoordinatesExtensionPoint
    {
        private readonly Rover rover_to_deploy;

        public CoordinatesExtensionPoint(Rover rover)
        {
            rover_to_deploy = rover;
        }

        public PlateauExtensionPoint at(Coordinates coordinates)
        {
            rover_to_deploy.Coordinates = coordinates;
            return new PlateauExtensionPoint(rover_to_deploy);
        }
    }
}