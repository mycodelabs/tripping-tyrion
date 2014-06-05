using NUnit.Framework;
using Rhino.Mocks;
using mars_rovers_project.Presentation;
using mars_rovers_project.Presentation.Contracts;
using mars_rovers_project.domain_plateau;
using mars_rovers_project.domain_plateau.contracts;

namespace mars_rovers_project.tests.Presentation
{
    [TestFixture]
    class plateau_presentation_concern
    {
        private IPlateauTasks plateau_tasks;
        private IPlateauPresentationCreation plateau_presentation_creation;

        [Test]
        public void should_create_plateau_given_space_separated_values()
        {
            plateau_tasks = new PlateauTasks(new PlateauFactory());
            plateau_presentation_creation = PlateauPresentationCreation.create_plateau;
            var result = plateau_presentation_creation(() => "5 5", plateau_tasks);
            Assert.AreEqual(result.coordinates.point_x, 5);
            Assert.AreEqual(result.coordinates.point_y, 5);
        }
    }
}
