using System;

using R5T.T0132;
using R5T.T0184;
using R5T.T0222;
using R5T.Z0043;


namespace R5T.F0143.F001
{
    [FunctionalityMarker]
    public partial interface IRepositoryOwnerNameOperator : IFunctionalityMarker
    {
        public IOrganizationName Get_OrganizationName(IRepositoryOwnerName repositoryOwnerName)
        {
            var output = repositoryOwnerName.Value switch
            {
                IOwnerNames.DavidCoats_Constant => Instances.OrganizationNames.DavidCoats,
                //IOrganizationNames.Rivet_Constant => Rivet is unhandled.
                IOwnerNames.SafetyCone_Constant => Instances.OrganizationNames.SafetyCone,
                _ => throw Instances.ExceptionOperator.Get_UnhandledValueException(repositoryOwnerName)
            };

            return output;
        }
    }
}
