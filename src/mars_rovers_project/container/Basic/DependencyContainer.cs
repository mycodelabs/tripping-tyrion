using System;

namespace mars_rovers_project.container.Basic
{
    public class DependencyContainer : IFetchDependencies
    {
        private readonly IFindAFactoryForADependency factories;
        private readonly ICreateErrorsFromFactoryContainerErrors creation_error_factory;
        public DependencyContainer(IFindAFactoryForADependency factories, ICreateErrorsFromFactoryContainerErrors creation_error_factory)
        {
            this.factories = factories;
            this.creation_error_factory = creation_error_factory;
        }

        public Dependency a<Dependency>()
        {
            return (Dependency) a(typeof (Dependency));
        }

        public object a(Type dependency_type)
        {
            try
            {
                var factory = this.factories.get_factory_to_create(dependency_type);
                var dependency = factory.create();
                return dependency;
            }
            catch (Exception exception)
            {
                throw creation_error_factory(dependency_type, exception);
            }
        }
    }
}
