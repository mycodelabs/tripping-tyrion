using System;
using System.Collections.Generic;

namespace mars_rovers_project.container.Basic
{
    public class DependecyFactories : IFindAFactoryForADependency
    {
        private readonly IDictionary<Type, ICreateOneDependency> all_the_factories;
        private readonly ICreateTheExceptionForAMissingDependencyFactory missing_dependency_error_handler;

        public DependecyFactories(IDictionary<Type, ICreateOneDependency> all_the_factories, ICreateTheExceptionForAMissingDependencyFactory missing_dependency_error_handler)
        {
            this.all_the_factories = all_the_factories;
            this.missing_dependency_error_handler = missing_dependency_error_handler;
        }

        public ICreateOneDependency get_factory_to_create(Type dependency_to_create)
        {
            if (all_the_factories.ContainsKey(dependency_to_create)) return all_the_factories[dependency_to_create];
            throw missing_dependency_error_handler(dependency_to_create);
        }
    }
}