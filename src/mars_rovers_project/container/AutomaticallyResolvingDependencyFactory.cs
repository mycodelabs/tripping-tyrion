using System;
using System.Linq;
using mars_rovers_project.container.Basic;

namespace mars_rovers_project.container
{
    public class AutomaticallyResolvingDependencyFactory : ICreateOneDependency
    {
        private Type type_to_create;
        private IPickAConstructor constructor_picker;
        private IFetchDependencies container;

        public AutomaticallyResolvingDependencyFactory(Type type_to_create, IPickAConstructor constructor_picker, IFetchDependencies container)
        {
            this.type_to_create = type_to_create;
            this.constructor_picker = constructor_picker;
            this.container = container;
        }

        public object create()
        {
            var ctor = constructor_picker(type_to_create);
            var parameters = ctor.GetParameters().Select(x => container.a(x.ParameterType));
            return ctor.Invoke(parameters.ToArray());
        }
    }
}