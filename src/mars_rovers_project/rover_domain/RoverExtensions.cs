namespace mars_rovers_project.rover_domain
{
    public static class RoverExtensions
    {
        public static RoverCoordinates deploy(this Rover rover)
        {
            return new RoverCoordinates(rover);
        }
    }
}