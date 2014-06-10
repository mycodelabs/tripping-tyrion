using System;
using mars_rovers_project.common;
using mars_rovers_project.domain_plateau;
using mars_rovers_project.domain_plateau.contracts;
using mars_rovers_project.domain_rover;
using mars_rovers_project.Presentation.Contracts;
using mars_rovers_project.shared;

namespace mars_rovers_project.Presentation
{
    public class UserInteraction : IUserInteraction
    {
        public readonly IPlateauTasks plateau_tasks;
        public readonly IDefaultConsole default_console;
        public readonly IPlateauPresentationCreation plateau_presentation_creation;
        public readonly IDeployRoverPositionAndDirection rover_position_and_direction;
        public readonly IPresentRoverCurrentCoordinates show_current_coordinates;

        public UserInteraction(IPlateauTasks plateauTasks, IDefaultConsole defaultConsole, IPlateauPresentationCreation plateauPresentationCreation, IDeployRoverPositionAndDirection roverPositionAndDirection, IPresentRoverCurrentCoordinates showCurrentCoordinates)
        {
            plateau_tasks = plateauTasks;
            default_console = defaultConsole;
            plateau_presentation_creation = plateauPresentationCreation;
            rover_position_and_direction = roverPositionAndDirection;
            show_current_coordinates = showCurrentCoordinates;
        }

        public string rover_instructions()
        {
            default_console.WriteLine("Instructions for Rover to move or spin L - spin Left, M- Move, R - Spin Right eg: (LMLMLMLMM):");
            return default_console.ReadLine();
        }

        public void rover_positions(out Coordinates coordinates, out char direction)
        {
            default_console.WriteLine("Deploy Robot coordinates and direction to point to in the format of '1 2 N'");
            rover_position_and_direction(default_console.ReadLine, out coordinates, out direction);
        }

        public Plateau plateau_creation()
        {
            default_console.WriteLine("Enter Boundaries of Plateau in the format of '5 5' : ");
            return plateau_presentation_creation(default_console.ReadLine, plateau_tasks);
        }

        public void navigate_rover(Coordinates coordinates, Plateau plateau, char direction, string instructions)
        {
            try
            {
                var rover = Instance.Create<Rover>();
                rover.deploy().at(coordinates).@in(plateau).facing_towards(direction).move_using(instructions);
                show_current_coordinates(rover, default_console);
            }
            catch (Exception ex)
            {
                default_console.WriteLine(ex.Message);
            }
        }
    }
}