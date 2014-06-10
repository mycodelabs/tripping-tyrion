using System;

namespace mars_rovers_project.container
{
    public interface IFetchDependencies
    {
        Dependency a<Dependency>();
        object a(Type dependency_type);
    }
}