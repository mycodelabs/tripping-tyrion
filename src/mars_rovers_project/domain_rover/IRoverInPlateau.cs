using mars_rovers_project.domain_plateau;

namespace mars_rovers_project.domain_rover
{
    public interface IRoverInPlateau
    {
        IDirection @in(Plateau plateau_to_deploy);
    }
}