using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.Models.Abstract;
using ApplicationsAndContracts.Models;

namespace ApplicationsAndContracts.Models
{
    public class ContractCatalog: SupportSortingList<ContractCatalogItem>
    {
        //public static CurrentContractCatalog CreateFrom(Catalog catalog)
        //{
        //    var list = catalog.Select(catalogItem => CurrentContractCatalogItem.CreateFrom(catalogItem)).Distinct().OrderBy(x => x.StateContractNumber).ToList();
        //    var result = new CurrentContractCatalog(list);
        //    return result;
        //}
        public static ContractCatalog CreateFrom(Catalog catalog, SupplierCatalogItem supplierCatalogItem)
        {
            var list = catalog.Where(catalogItem => catalogItem.StateContractId == supplierCatalogItem.StateContractId)
                               .Select(catalogItem => ContractCatalogItem.CreateFrom(catalogItem))
                               .Distinct()
                               .OrderBy(catalogItem => catalogItem.StateContractNumber)
                               .ToList();
            var result = new ContractCatalog(list);
            return result;
        }


        private  ContractCatalog(List<ContractCatalogItem>items): base(items)
        {

        }
    }
}
