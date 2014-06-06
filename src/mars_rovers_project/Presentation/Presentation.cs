namespace mars_rovers_project.Presentation
{
    public class Presentation 
    {
        public static IPresentRoverCurrentCoordinates Show = (rover, default_console) =>
        {
            default_console.WriteLine("Current position of rover : ");
            default_console.WriteLine(string.Format("{0} {1} {2}", rover.Coordinates.point_x,
                rover.Coordinates.point_y, rover.Heading.Key.ToString().ToUpper()));
        };
    }
}