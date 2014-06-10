namespace mars_rovers_project.Presentation
{
    public class ProgramBuilder
    {
        public static Program build()
        {
            Registry.Register();
            return new Program(ContainerGateway.resolve<IUserInteraction>());
        }
    }
}
