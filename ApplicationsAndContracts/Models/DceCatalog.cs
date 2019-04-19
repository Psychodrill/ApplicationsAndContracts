using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.Models.Abstract;

namespace ApplicationsAndContracts.Models
{
    public class DceCatalog:SupportSortingList<DceCatalogItem>
    {
        public static DceCatalog CreateFrom(Catalog catalog, ApplicationCatalogItem applicationCatalogItem)
        {
            var list = catalog.Where(catalogItem => catalogItem.ApplicationId == applicationCatalogItem.ApplicationId)
                               .Select(catalogItem => DceCatalogItem.CreateFrom(catalogItem))
                               .Distinct()
                               .OrderBy(catalogItem => catalogItem.DceNumber)
                               .ToList();
            var result = new DceCatalog(list);
            return result;
        }

        private DceCatalog(List<DceCatalogItem> items) : base(items)
        {

        }


    }
}
