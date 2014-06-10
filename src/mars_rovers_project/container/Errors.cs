using System;
using mars_rovers_project.container.Basic;

namespace DependencyInjection.app.Startup
{
    public class Errors
    {
        public static ICreateTheExceptionForAMissingDependencyFactory factory_not_registered_for_type =
            (type_that_has_no_factory) => 
            new Exception(string.Format("There is no factory registered that can create an instance of type #{0}", type_that_has_no_factory));

        public static ICreateErrorsFromFactoryContainerErrors dependency_creation_error = (type_that_could_not_be_created, exception_thrown_by_container_framework) 
                                                                                          => 
                                                                                          new Exception(string.Format("There was an error trying to create an instance of: #{0}", type_that_could_not_be_created));
    }
}