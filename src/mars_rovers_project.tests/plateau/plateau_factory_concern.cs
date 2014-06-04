using NUnit.Framework;
using mars_rovers_project.plateau;
using mars_rovers_project.shared;

namespace mars_rovers_project.tests.plateau
{
    [TestFixture]
    public class plateau_factory_concern
    {
        public class when_factory_is_asked_to_create_plateau
        {
            [Test]
            public void should_return_a_new_instance_with_given_coordinates()
            {
                var plateau_factory = new PlateauFactory();
                var actual_coordinates = new Coordinates {point_x = 5, point_y = 5};
                var result = plateau_factory.create_boundary(actual_coordinates);

                Assert.AreEqual(result.coordinates.point_x, actual_coordinates.point_x);
                Assert.AreEqual(result.coordinates.point_y, actual_coordinates.point_y);
            }
        }
    }
}