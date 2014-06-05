using mars_rovers_project.infrastructure;

namespace mars_rovers_project.rover_domain
{
    public class Heading : LookUp<Heading>
    {
        public static Heading north = new Heading('n');
        public static Heading south = new Heading('s');
        public static Heading east = new Heading('e');
        public static Heading west = new Heading('w');

        private Heading(char direction)
        {
            directionLookup.Add(direction,this);            
        }
    }
}