using mars_rovers_project.shared;

namespace mars_rovers_project.domain_plateau
{
    public class Plateau
    {
        public Plateau()
        {
            coordinates = new Coordinates();           
        }

        public Coordinates coordinates { get; set; }
    }
}