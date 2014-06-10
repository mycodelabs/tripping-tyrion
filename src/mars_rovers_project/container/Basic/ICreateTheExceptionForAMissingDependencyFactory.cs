using System;

namespace mars_rovers_project.container.Basic
{
    public delegate Exception ICreateTheExceptionForAMissingDependencyFactory(Type missing_dependency_factory);
}