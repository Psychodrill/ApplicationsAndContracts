﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.Models.Abstract;

namespace ApplicationsAndContracts.Models
{
    public class SupplierCatalog:SupportSortingList<SupplierCatalogItem>
    {
        public static SupplierCatalog CreateFrom(Catalog catalog)
        {
            var list = catalog.Select(catalogItem => SupplierCatalogItem.CreateFrom(catalogItem)).Distinct().OrderBy(x => x.SupplierName).ToList();
            var result = new SupplierCatalog(list);
            return result;
        }

        private SupplierCatalog (List<SupplierCatalogItem> items): base(items)
        {

        }

    }
}
