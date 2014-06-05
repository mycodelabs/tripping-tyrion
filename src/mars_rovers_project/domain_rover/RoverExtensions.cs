namespace mars_rovers_project.domain_rover
{
    public static class RoverExtensions
    {
        public static RoverCoordinates deploy(this Rover rover)
        {
            return new RoverCoordinates(rover);
        }
    }
}