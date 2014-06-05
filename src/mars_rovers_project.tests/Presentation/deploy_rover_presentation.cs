using NUnit.Framework;
using mars_rovers_project.Presentation;
using mars_rovers_project.Presentation.Contracts;
using mars_rovers_project.shared;

namespace mars_rovers_project.tests.Presentation
{
    [TestFixture]
    public class deploy_rover_presentation
    {
        private IDeployRoverPositionAndDirection postion_and_direction;

        [Test]
        public void should_get_position_and_direction_to_deploy_a_rover()
        {
            postion_and_direction = DeployRoverPositionAndDirection.get;
            Coordinates coordinates;
            char direction;
            postion_and_direction(() => "1 2 N", out coordinates, out direction);
            Assert.AreEqual(coordinates.point_x, 1);
            Assert.AreEqual(coordinates.point_y, 2);
            Assert.AreEqual(direction, 'n');
        }
    }
}
