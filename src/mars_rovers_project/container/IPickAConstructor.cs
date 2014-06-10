using System;
using System.Reflection;

namespace mars_rovers_project.container
{
    public delegate ConstructorInfo IPickAConstructor(Type type_to_inspect);
}