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
                SELECT [ApplicationId],
                       [ApplicationNumber],
                       [ApplicationDate],
                       [StateContractId],
                       [ApplicationStatus],
                       [Department]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetApplicationList]()";

        internal const string GetStateContractList = @"
                SELECT [StateContractId],
                       [StateContractNumber],
				       [ReasonId],            
				       [IdGoz],               
				       [IdKazn]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetStateContractList]()";

        internal const string GetOrderList = @"
                SELECT [ApplicationId],
                       [OrderNumber],
                       [SetFrom],
                       [SetTo]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetOrderList]()";

        internal const string GetProductList = @"
                SELECT [IdInd],
                       [ProductNumber],
                       [ProductIndex],
                       [ProductName],
                       [ProductAlias],
                       [ApplicationId],
                       [ProductStructureId]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetProductList]()";

        internal const string GetDceList = @"
                SELECT [ApplicationId],
                       [DceStructureId],
                       [DceNumber],
                       [DceAlias],
                       [DceName],
                       [Quantity]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetDceList]()";

        internal const string GetDceQuantityList = @"
                SELECT [ApplicationId],
                       [Quantity]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetDceList]()";

        internal const string GetCatalog = @"
                SELECT [ApplicationId],
                       [SupplierCode],
                       [SupplierName],
                       [ContractId],
                       [ContractNumber],
                       [ContractDate],
                       [ApplicationNumber],
                       [ApplicationDate],
                       [StateContractId],
				       [ReasonId],            
				       [IdGoz],               
				       [IdKazn],
                       [ApplicationStatus],
                       [Department],
                       [StateContractNumber],
                       [OrderNumber],
                       [SetFrom],
                       [SetTo],
                       [ProductNumber],
                       [ProductIndex],
                       [ProductAlias],
                       [ProductName],
                       [DceNumber],
                       [DceAlias],
                       [DceName],
                       [Quantity],
                       [ProductStructureId],
                       [DceStructureId],
                       [DceProductQuantity]
                  FROM [dbo].[ft_ApplicationsAndContracts_GetCatalog](@supplierName,
                                                                      @contractNumber,
                                                                      @contractDate,
                                                                      @applicationNumber,
                                                                      @applicationDate,
                                                                      @applicationStatus,
                                                                      @department,
                                                                      @stateContractNumber,
                                                                      @orderNumber,
                                                                      @productNumber,
                                                                      @productIndex,
                                                                      @productAlias,
                                                                      @productName,
                                                                      @dceNumber,
                                                                      @dceAlias,
                                                                      @dceName)";


    }


}
