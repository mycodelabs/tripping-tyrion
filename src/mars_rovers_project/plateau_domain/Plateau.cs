using mars_rovers_project.shared;

namespace mars_rovers_project.plateau_domain
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