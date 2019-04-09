using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationsAndContracts.Models
{
    public class CatalogItem
    {
        public static CatalogItem CreateFrom(DataRow row)
        {
            var result = new CatalogItem();
            return result;
        }
    }
}
