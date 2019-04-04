using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationsAndContracts.DataAccess
{
     class SQL
    {

        internal const string GetSDS = @"
                SELECT [UserRole],
                       [UserName],
                       [UserDepartment],
                       [Date]
                  FROM [dbo].[ft_WorkWithDce_GetSDS]()";

        internal const string GetSupplierList = @"
                SELECT [SupplierCode],
                       [SupplierName]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetSupplierList]()";

        internal const string GetContractList = @"
                SELECT [ContractId],
                       [ContractNumber],
                       [ContractDate]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetContractList]()";

        internal const string GetApplicationList = @"
                SELECT [ApplicationNumber],
                       [ApplicationDate],
                       [ApplicationStatus],
                       [Department]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetApplicationList]()";

        internal const string GetStateContractList = @"
                SELECT [ContractId],
                       [ContractNumber]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetStateContractList]()";

        internal const string GetOrderList = @"
                SELECT [ApplicationId],
                       [Order]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetOrder]()";

        internal const string GetProductList = @"
                SELECT [IdInd],
                       [ProductId],
                       [ProductIndex],
                       [ProductName],
                       [ProductAlias],
                       [ApplicationId]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetProductList]()";

        internal const string GetDceList = @"
                SELECT [ApplicationId],
                       [DceNumber],
                       [DceAlias],
                       [DceName]
                  FROM [[dbo].[ft_ApplicationsAndContracts_GetDceList]()]";


    }


}
