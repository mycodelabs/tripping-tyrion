using System.Collections.Generic;
using System.Reflection;

namespace mars_rovers_project.infrastructure
{
    public class LookUp<Entity>
    {
        public static readonly IDictionary<object, Entity> look_up = new Dictionary<object, Entity>();

        public static Entity Get(object key)
        {
            EnsureValues();
            Entity entity;
            look_up.TryGetValue(key, out entity);
            return entity;
        }

        private static void EnsureValues() 
        {
            if (look_up.Count != 0) 
            {
                return;
            }

            var fieldInfos = typeof(Entity).GetFields(BindingFlags.Static | BindingFlags.Public);
            fieldInfos[0].GetValue(null);
        }
    }
}