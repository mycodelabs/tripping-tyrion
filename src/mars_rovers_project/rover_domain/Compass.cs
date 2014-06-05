using mars_rovers_project.infrastructure;

namespace mars_rovers_project.rover_domain
{
    public class Compass : LookUp<Compass>
    {
        public char left_direction { get; set; }
        public char right_direction { get; set; }

        public static Compass north = new Compass('n', 'w', 'e');
        public static Compass south = new Compass('s', 'e', 'w');
        public static Compass east = new Compass('e', 'n', 's');
        public static Compass west = new Compass('w', 's', 'n');

        private Compass(char direction, char left, char right)
        {
            left_direction = left;
            right_direction = right;
            look_up.Add(direction,this);            
        }
    }
}