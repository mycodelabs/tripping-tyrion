using mars_rovers_project.rover_domain.contracts;
using mars_rovers_project.shared;

namespace mars_rovers_project.rover_domain
{
    public class ControlRover : IControlRover
    {
        private readonly Rover rover;
        private IRoverTasks rover_tasks { get { return new RoverTasks(new RoverMove()); }}
        
        public ControlRover(Rover rover)
        {
            this.rover = rover;
        }

        public Rover move_using(string instructions)
        {
            foreach (var instruction in instructions)
            {
                Spin.Get(instruction).apply(rover_tasks, rover);
            }
            return rover;
        }
    }
}