using System;


namespace R5T.F0143.F001
{
    public class RepositoryOwnerNameOperator : IRepositoryOwnerNameOperator
    {
        #region Infrastructure

        public static IRepositoryOwnerNameOperator Instance { get; } = new RepositoryOwnerNameOperator();


        private RepositoryOwnerNameOperator()
        {
        }

        #endregion
    }
}
