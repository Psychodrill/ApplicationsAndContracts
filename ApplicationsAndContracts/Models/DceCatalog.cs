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

        
        public static DceCatalog CreateFrom(ApplicationCatalogItem applicationCatalogItem)
        {

            DceCatalog innerlist = Create();
            var list = innerlist.Where(catalogItem => (applicationCatalogItem.ApplicationId == catalogItem.ApplicationId)).Distinct().OrderBy(x => x.ApplicationId).ToList();
            var result = new DceCatalog(list);
            return result;

        }

        public static DceCatalog Create()
        {
            var dceList = DceList.GetDceList();
            var quantityList = DceQuantityList.GetDceQuantityList();

            var innerList = dceList.Join(quantityList, d => d.ApplicationId, q => q.ApplicationId, (d, q) => DceCatalogItem.CreateFrom(d, q)).ToList();
            DceCatalog dceCatalog = new DceCatalog(innerList);
            return dceCatalog;

        }



        private DceCatalog(List<DceCatalogItem> items) : base(items)
        {

        }


    }
}
