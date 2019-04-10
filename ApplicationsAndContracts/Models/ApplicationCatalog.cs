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

        }
    }
}
