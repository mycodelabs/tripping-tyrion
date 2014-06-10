using System;
using System.Collections.Generic;
using DependencyInjection.app.Startup;
using mars_rovers_project.container;
using mars_rovers_project.container.Basic;

namespace mars_rovers_project.Presentation
{
    public class ContainerGateway
    {
        private static Dictionary<Type, ICreateOneDependency> all_factories;
        private static IFetchDependencies the_container;

        public static void run()
        {
            all_factories = new Dictionary<Type, ICreateOneDependency>();
            var factories = new DependecyFactories(all_factories, Errors.factory_not_registered_for_type);
            the_container = new DependencyContainer(factories, Errors.dependency_creation_error);

            Dependencies.container_factory = () => the_container;
        }

        public static Contract resolve<Contract>()
        {
            return the_container.a<Contract>();
        }

        public static void register_dependency<Contract, Implementation>()
        {
            register_factory<Contract>(new AutomaticallyResolvingDependencyFactory(typeof(Implementation), ContainerFacilities.greediest_ctor_picker, the_container));
        }

        public static void register_dependency<Contract>(Contract Implementation)
        {
            register_factory<Contract>(new AnonymousDependencyFactory(() => Implementation));
        }

        static void register_factory<contract>(ICreateOneDependency factory)
        {
            all_factories[typeof(contract)] = factory;
        }
    }
}