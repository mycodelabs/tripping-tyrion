using System;
using mars_rovers_project.infrastructure;
using mars_rovers_project.rover_domain;
using mars_rovers_project.rover_domain.contracts;

namespace mars_rovers_project.shared
{
    public class Spin : LookUp<Spin>
    {
        public static Spin left = new Spin('L', (tasks, rover) => tasks.spin_left(ref rover));
        public static Spin right = new Spin('R', (tasks, rover) => tasks.spin_right(ref rover));
        public static Spin move = new Spin('M', (tasks, rover) => tasks.move_a_step(ref rover));
        
        public Action<IRoverTasks, Rover> apply { get; set; }

        private Spin(char key, Action<IRoverTasks, Rover> rover_tasks)
        {
            this.apply = rover_tasks;
            look_up.Add(key, this);
        }
    }
}