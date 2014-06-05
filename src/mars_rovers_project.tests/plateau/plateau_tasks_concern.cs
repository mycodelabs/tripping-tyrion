using System;
using NUnit.Framework;
using Rhino.Mocks;
using mars_rovers_project.domain_plateau;
using mars_rovers_project.domain_plateau.contracts;
using mars_rovers_project.shared;

namespace mars_rovers_project.tests.plateau
{
    [TestFixture]
    public class plateau_tasks_concern
    {
        [TestFixture]
        public class when_the_factory_is_asked_to_create_plateau
        {
            private Coordinates coordinates;
            private IPlateauFactory plateau_factory;
            private PlateauTasks plateau_tasks;

            [SetUp]
            public void setup()
            {
                plateau_factory = MockRepository.GenerateMock<IPlateauFactory>();
                coordinates = new Coordinates();
                plateau_tasks = new PlateauTasks(plateau_factory);
            }

            [Test]
            public void should_ask_plateau_factory()
            {
                plateau_factory.Expect(x => x.create_boundary(coordinates));
                plateau_tasks.create(coordinates);
                plateau_factory.VerifyAllExpectations();
            }

            [Test]
            [ExpectedException(typeof(FormatException))]
            public void should_validate_the_coordinates_to_be_positive_integers()
            {
                coordinates.point_x = -1;
                plateau_tasks.create(coordinates);
            }
        }
    }
}