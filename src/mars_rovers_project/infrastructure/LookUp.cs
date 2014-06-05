using System.Collections.Generic;

namespace mars_rovers_project.infrastructure
{
    public class LookUp<Entity>
    {
        public static readonly IDictionary<object, Entity> directionLookup = new Dictionary<object, Entity>();

        public static Entity Get(object direction) 
        {
            Entity entity;
            directionLookup.TryGetValue(direction, out entity);
            return entity;
        }
    }
}