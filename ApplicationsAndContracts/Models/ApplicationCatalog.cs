using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.Models;
using ApplicationsAndContracts.Models.Abstract;

namespace ApplicationsAndContracts.Models
{
    public class ApplicationCatalog:SupportSortingList<ApplicationCatalogItem>
    {
        public static ApplicationCatalog CreateFrom(Catalog catalog)
        {
            var list = catalog.Select(catalogItem => ApplicationCatalogItem.CreateFrom(catalogItem)).Distinct().OrderBy(x => x.ApplicationNumber).ToList();
            var result = new ApplicationCatalog(list);
            return result;
        }

        private ApplicationCatalog(List<ApplicationCatalogItem> items) : base(items)
        {
        }
    }
}
