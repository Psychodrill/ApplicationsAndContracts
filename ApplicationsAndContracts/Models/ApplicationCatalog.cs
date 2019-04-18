using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
            //var list = catalog.
            var result = new ApplicationCatalog(list);
            //var result = new ApplicationCatalog()
            return result;
        }

        private ApplicationCatalog(List<ApplicationCatalogItem> items) : base(items)
        {
        }
    }
}
