using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.Models.Abstract;

namespace ApplicationsAndContracts.Models
{
    public class CurrentContractCatalog: SupportSortingList<CurrentContractCatalogItem>
    {
        //public static CurrentContractCatalog CreateFrom(Catalog catalog)
        //{
        //    var list = catalog.Select(catalogItem => CurrentContractCatalogItem.CreateFrom(catalogItem)).Distinct().OrderBy(x => x.StateContractNumber).ToList();
        //    var result = new CurrentContractCatalog(list);
        //    return result;
        //}
        public static CurrentContractCatalog CreateFrom(Catalog catalog, SupplierCatalogItem supplierCatalogItem)
        {
            var list = catalog.Where(catalogItem => catalogItem.StateContractId == supplierCatalogItem.StateContractId)
                               .Select(catalogItem => CurrentContractCatalogItem.CreateFrom(catalogItem))
                               .Distinct()
                               .OrderBy(catalogItem => catalogItem.StateContractNumber)
                               .ToList();
            var result = new CurrentContractCatalog(list);
            return result;
        }


        private  CurrentContractCatalog(List<CurrentContractCatalogItem>items): base(items)
        {

        }
    }
}
