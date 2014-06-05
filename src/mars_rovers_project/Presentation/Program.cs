using System;
using mars_rovers_project.Presentation.Contracts;
using mars_rovers_project.common;
using mars_rovers_project.plateau_domain;
using mars_rovers_project.plateau_domain.contracts;
using mars_rovers_project.rover_domain;
using mars_rovers_project.shared;

namespace mars_rovers_project.Presentation
{
    public class Program
    {
        private readonly IPlateauTasks plateau_tasks;
        private readonly IDefaultConsole default_console;
        private readonly IPlateauPresentationCreation plateau_presentation_creation;
        private readonly IDeployRoverPositionAndDirection rover_position_and_direction;

        public Program(IPlateauTasks plateau_tasks, IDefaultConsole default_console, IPlateauPresentationCreation plateau_presentation_creation, IDeployRoverPositionAndDirection rover_position_and_direction)
        {
            this.plateau_tasks = plateau_tasks;
            this.default_console = default_console;
            this.plateau_presentation_creation = plateau_presentation_creation;
            this.rover_position_and_direction = rover_position_and_direction;
        }

        static void Main(string[] args)
        {
            var program = ProgramBuilder.build();
            program.run();
        }

        private void run()
        {
            var plateau = plateau_creation();
            while (true)
            {
                Coordinates coordinates;
                char direction;
                rover_positions(out coordinates, out direction);
                navigate_rover(coordinates, plateau, direction);
            }
        }

        private void navigate_rover(Coordinates coordinates, Plateau plateau, char direction)
        {
            default_console.WriteLine(
                "Instructions for Rover to move or spin L - spin Left, M- Move, R - Spin Right eg: (LMLMLMLMM):");
            var instructions = default_console.ReadLine();
            try
            {
                var rover =
                    Instance.Create<Rover>().deploy().at(coordinates).@in(plateau).facing_towards(direction).move_using(instructions);

                default_console.WriteLine("Current position of rover : ");
                default_console.WriteLine(string.Format("{0} {1} {2}", rover.Coordinates.point_x,
                                                        rover.Coordinates.point_y,
                                                        rover.Heading.Key.ToString().ToUpper()));
            }
            catch (Exception ex)
            {
                default_console.WriteLine(ex.Message);
            }
        }

        private void rover_positions(out Coordinates coordinates, out char direction)
        {
            default_console.WriteLine("Deploy Robot coordinates and direction to point to in the format of '1 2 N'");
            rover_position_and_direction(default_console.ReadLine, out coordinates, out direction);
        }

        private Plateau plateau_creation()
        {
            default_console.WriteLine("Enter Boundaries of Plateau in the format of '5 5' : ");
            return plateau_presentation_creation(default_console.ReadLine, plateau_tasks);
        }
    }
}
