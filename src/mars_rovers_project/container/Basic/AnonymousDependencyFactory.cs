using System;

namespace mars_rovers_project.container.Basic
{
    public class AnonymousDependencyFactory : ICreateOneDependency
    {
        private Func<object> real_factory;

        public AnonymousDependencyFactory(Func<object> real_factory)
        {
            this.real_factory = real_factory;
        }

        public object create()
        {
            return real_factory();
        }
    }
}