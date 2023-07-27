using System;


namespace R5T.F0143.F001
{
    public class OrganizationNameOperator : IOrganizationNameOperator
    {
        #region Infrastructure

        public static IOrganizationNameOperator Instance { get; } = new OrganizationNameOperator();


        private OrganizationNameOperator()
        {
        }

        #endregion
    }
}
