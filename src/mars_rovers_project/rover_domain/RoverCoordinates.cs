using mars_rovers_project.shared;

namespace mars_rovers_project.rover_domain
{
    public class RoverCoordinates
    {
        private readonly Rover rover_to_deploy;

        public RoverCoordinates(Rover rover)
        {
            rover_to_deploy = rover;
        }

        public RoverInPlateau at(Coordinates coordinates)
        {
            rover_to_deploy.Coordinates = coordinates;
            return new RoverInPlateau(rover_to_deploy);
        }
    }
}