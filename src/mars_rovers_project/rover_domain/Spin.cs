using System;
using mars_rovers_project.infrastructure;
using mars_rovers_project.rover_domain.contracts;

namespace mars_rovers_project.rover_domain
{
    public class Spin : LookUp<Spin>
    {
        public static Spin spin_left = new Spin('L', (tasks, rover) => tasks.spin_left(ref rover));
        public static Spin spin_right = new Spin('R', (tasks, rover) => tasks.spin_right(ref rover));
        public static Spin move_a_step = new Spin('M', (tasks, rover) => tasks.move_a_step(ref rover));
        
        public Action<IRoverTasks, Rover> rover_tasks { get; set; }

        private Spin(char key, Action<IRoverTasks, Rover> rover_tasks)
        {
            this.rover_tasks = rover_tasks;
            look_up.Add(key, this);
        }
    }
}