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
    
    }


}
