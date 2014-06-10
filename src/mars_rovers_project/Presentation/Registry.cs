using mars_rovers_project.Presentation.Contracts;
using mars_rovers_project.domain_plateau;
using mars_rovers_project.domain_plateau.contracts;

namespace mars_rovers_project.Presentation
{
    public class Registry
    {
        public static void Register()
        {
            ContainerGateway.run();
            ContainerGateway.register_dependency<IPlateauFactory, PlateauFactory>();
            ContainerGateway.register_dependency<IPlateauTasks, PlateauTasks>();
            ContainerGateway.register_dependency<IDefaultConsole, DefaultConsole>();
            ContainerGateway.register_dependency<IUserInteraction, UserInteraction>();
            ContainerGateway.register_dependency(PlateauPresentationCreation.create_plateau);
            ContainerGateway.register_dependency(DeployRoverPositionAndDirection.get);
            ContainerGateway.register_dependency(Presentation.Show);
        }
    }
}