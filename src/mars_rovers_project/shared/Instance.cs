namespace mars_rovers_project.common
{
    public class Instance
    {
        public static Entity Create<Entity>() where Entity : new()
        {
            return new Entity();
        }
    }
}