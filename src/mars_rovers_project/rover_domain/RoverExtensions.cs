namespace mars_rovers_project.rover_domain
{
    public static class RoverExtensions
    {
        public static CoordinatesExtensionPoint deploy(this Rover rover)
        {
            return new CoordinatesExtensionPoint(rover);
        }
    }
}