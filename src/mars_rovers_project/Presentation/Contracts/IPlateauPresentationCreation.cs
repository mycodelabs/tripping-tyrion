using System;
using mars_rovers_project.domain_plateau;
using mars_rovers_project.domain_plateau.contracts;

namespace mars_rovers_project.Presentation.Contracts
{
    public delegate Plateau IPlateauPresentationCreation(Func<string> space_separated_coordinates, IPlateauTasks plateau_tasks);
}