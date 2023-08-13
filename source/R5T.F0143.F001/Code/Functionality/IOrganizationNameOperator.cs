using System;

using R5T.T0132;
using R5T.T0186;
using R5T.T0222;
using R5T.Z0059;


namespace R5T.F0143.F001
{
    [FunctionalityMarker]
    public partial interface IOrganizationNameOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Converts one of the top-level <see cref="IOrganizationNames"/> (<see cref="IOrganizationName"/>) into one of the
        /// <see cref="Z0043.IOwnerNames"/> (<see cref="IOwnerName"/>, which is a <see cref="IGitHubRepositoryOwnerName"/>).
        /// </summary>
        public IOwnerName Get_RepositoryOwnerName(IOrganizationName organizationName)
        {
            var output = organizationName.Value switch
            {
                IOrganizationNames.DavidCoats_Constant => Instances.OwnerNames.DavidCoats,
                //IOrganizationNames.Rivet_Constant => Rivet is unhandled.
                IOrganizationNames.SafetyCone_Constant => Instances.OwnerNames.SafetyCone,
                _ => throw Instances.ExceptionOperator.Get_UnhandledValueException(organizationName)
            };

            return output;
        }

        /// <summary>
        /// Converts one of the top-level <see cref="IOrganizationNames"/> (<see cref="IOrganizationName"/>) into one of the
        /// <see cref="Z0043.IOwnerNames"/> (<see cref="IGitHubRepositoryOwnerName"/>).
        /// </summary>
        public IGitHubRepositoryOwnerName Get_GitHubRepositoryOwnerName(IOrganizationName organizationName)
        {
            return this.Get_RepositoryOwnerName(organizationName);
        }
    }
}
