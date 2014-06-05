using System;
using mars_rovers_project.domain_rover.contracts;
using mars_rovers_project.infrastructure;

namespace mars_rovers_project.domain_rover
{
    public class Compass : LookUp<Compass>
    {
        public char left_direction { get; set; }
        public char right_direction { get; set; }
        public Action<IRoverMove, Rover> apply { get; set; }
        public char Key { get; set; }
     
        public static Compass north = new Compass('n', 'w', 'e', (move, rover) => move.head_north(ref rover));
        public static Compass south = new Compass('s', 'e', 'w', (move, rover) => move.head_south(ref rover));
        public static Compass east = new Compass('e', 'n', 's', (move, rover) => move.head_east(ref rover));
        public static Compass west = new Compass('w', 's', 'n', (move, rover) => move.head_west(ref rover));

        private Compass(char direction, char left, char right, Action<IRoverMove, Rover> move)
        {
            Key = direction;
            apply = move;
            left_direction = left;
            right_direction = right;
            look_up.Add(direction,this);            
        }
    }
}