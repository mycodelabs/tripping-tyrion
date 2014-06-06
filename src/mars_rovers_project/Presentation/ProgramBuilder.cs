using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using mars_rovers_project.domain_plateau;
using mars_rovers_project.domain_plateau.contracts;

namespace mars_rovers_project.Presentation
{
    public class ProgramBuilder
    {
        public static Program build()
        {
            Container.Register<IPlateauTasks, PlateauTasks>();
            Container.Register<IPlateauFactory, PlateauFactory>();

            var plateau_tasks1 = Container.Resolve<IPlateauTasks>();
            var plateau_tasks = new PlateauTasks(new PlateauFactory());
            var default_console = new DefaultConsole();
            var plateau_presentation_creation = PlateauPresentationCreation.create_plateau;
            var deploy_position_and_direction = DeployRoverPositionAndDirection.get;
            var show_current_coordinates = Presentation.Show;
            var user_interactions = new UserInteraction(plateau_tasks, default_console, plateau_presentation_creation,
                deploy_position_and_direction, show_current_coordinates);
            return new Program(user_interactions);
        }
    }
}

public class Container
{
    public static IDictionary<Type,object> container = new Dictionary<Type, object>();

    public static void Register<Interface, Class>()
    {
        container.Add(typeof (Interface), FormatterServices.GetUninitializedObject(typeof (Class)));
    }

    public static T Resolve<T>()
    {
        return (T) container[typeof (T)];
    }
}