using System;
using mars_rovers_project.plateau_domain;
using mars_rovers_project.plateau_domain.contracts;

namespace mars_rovers_project.Presentation.Contracts
{
    public delegate Plateau IPlateauPresentationCreation(Func<string> space_separated_coordinates, IPlateauTasks plateau_tasks);
}