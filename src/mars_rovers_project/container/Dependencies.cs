using System;

namespace mars_rovers_project.container
{
    public class Dependencies
    {
        public static ISetupTheContainer container_factory = () =>
            {
                throw new NotImplementedException(
                    "The container is not setup, make sure you have an initialisation file where the container is setup");
            };

        public static IFetchDependencies fetch{
            get { return container_factory(); }
        }
    }
}
