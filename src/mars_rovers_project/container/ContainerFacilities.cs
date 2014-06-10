using System.Linq;

namespace mars_rovers_project.container
{
  public class ContainerFacilities
  {
    public static IPickAConstructor greediest_ctor_picker = (type) =>
    {
      return  type.GetConstructors().OrderByDescending(x => x.GetParameters().Length).First();
    };
  }
}