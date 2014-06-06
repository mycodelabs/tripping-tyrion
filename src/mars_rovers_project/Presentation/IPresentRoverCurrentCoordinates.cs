using mars_rovers_project.domain_rover;
using mars_rovers_project.Presentation.Contracts;

namespace mars_rovers_project.Presentation
{
    public delegate void IPresentRoverCurrentCoordinates(Rover rover, IDefaultConsole defaultConsole);
}