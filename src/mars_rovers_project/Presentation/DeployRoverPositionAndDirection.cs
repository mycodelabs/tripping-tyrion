using System;
using mars_rovers_project.Presentation.Contracts;
using mars_rovers_project.shared;

namespace mars_rovers_project.Presentation
{
    public class DeployRoverPositionAndDirection
    {
        public static IDeployRoverPositionAndDirection get = (Func<string> position,
                                                              out Coordinates coordinates,
                                                              out char direction) =>
            {
                var positions = position().Split(' ');
                coordinates = new Coordinates{ point_x =  int.Parse(positions[0]), point_y = int.Parse(positions[1])};
                direction = char.Parse(positions[2].ToLower());
            };
    }
}