using System;
using mars_rovers_project.shared;

namespace mars_rovers_project.Presentation.Contracts
{
    public delegate void IDeployRoverPositionAndDirection(Func<string> space_separated_position, out Coordinates coordinates, out char direction);
}