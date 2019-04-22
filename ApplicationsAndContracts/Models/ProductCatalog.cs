using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ApplicationsAndContracts.Models.Abstract;
using ApplicationsAndContracts.Models;

namespace ApplicationsAndContracts.Models
{
     public class ProductCatalog:SupportSortingList<ProductCatalogItem>
    {
        public static  ProductCatalog (ApplicationCatalogItem applicationCatalogItem)
        {
           var innerList =  ;

           
        }
        

        //public List<Product> GetProductList()
        //{
        //    var result = this.Select(x => x.ApplicationDate).Distinct().OrderByDescending(x => x).ToList();
        //    return result;
        //}
    }
}
