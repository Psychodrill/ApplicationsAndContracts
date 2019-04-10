using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ApplicationsAndContracts.Models;

namespace ApplicationsAndContracts.Models
{
    public class CatalogItem
    {
        public static CatalogItem CreateFrom(DataRow row)
        {
            var result = new CatalogItem();

            result.ApplicationCatalogItem = ApplicationCatalogItem.CreateFrom(row);
            return result;
        }













        public ApplicationCatalogItem ApplicationCatalogItem { get; private set; }
    }

}
