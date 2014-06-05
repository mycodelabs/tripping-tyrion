namespace mars_rovers_project.rover_domain
{
    public class DirectionExtensionPoint
    {
        private readonly Rover rover_to_deploy;

        public DirectionExtensionPoint(Rover roverToDeploy)
        {
            rover_to_deploy = roverToDeploy;
        }

        public Rover facing(Heading direction)
        {
            rover_to_deploy.Heading = direction;
            return rover_to_deploy;
        }
    }
}