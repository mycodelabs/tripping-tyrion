using System;

namespace mars_rovers_project.container.Basic
{
    public delegate Exception ICreateErrorsFromFactoryContainerErrors(
        Type type_that_could_not_be_created, Exception inner_exception);
}