using mars_rovers_project.shared;

namespace mars_rovers_project.Presentation
{
    public class Program
    {
        private readonly IUserInteraction user_interaction;

        public Program(IUserInteraction user_interaction)
        {
            this.user_interaction = user_interaction;
        }

        static void Main(string[] args)
        {
            var program = ProgramBuilder.build();
            program.run();
        }

        private void run()
        {
            var plateau = user_interaction.plateau_creation();
            while (true)
            {
                Coordinates coordinates;
                char direction;
                user_interaction.rover_positions(out coordinates, out direction);
                user_interaction.navigate_rover(coordinates, plateau, direction, user_interaction.rover_instructions());
            }
        }
    }
}