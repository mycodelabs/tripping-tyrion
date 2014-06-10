using System;

namespace mars_rovers_project.container.Basic
{
    public interface IFindAFactoryForADependency
    {
        ICreateOneDependency get_factory_to_create(Type type);
    }
}