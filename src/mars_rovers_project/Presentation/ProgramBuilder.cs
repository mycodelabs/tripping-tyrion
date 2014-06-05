using mars_rovers_project.Presentation.Contracts;
using mars_rovers_project.plateau_domain;

namespace mars_rovers_project.Presentation
{
    public class ProgramBuilder
    {
        public static Program build()
        {
            var plateau_tasks = new PlateauTasks(new PlateauFactory());
            var default_console = new DefaultConsole();
            var plateau_presentation_creation = PlateauPresentationCreation.create_plateau;
            var deploy_position_and_direction = DeployRoverPositionAndDirection.get;
            return new Program(plateau_tasks, default_console, plateau_presentation_creation, deploy_position_and_direction);
        }
    }
}