using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationsAndContracts.Models
{
    public class Product
    {
        public static Product CreateFrom (DataRow row)
        {
            var result = new Product();
            //result.IdInd = row.Field<int?>("IdInd");
            result.ProductNumber = row.Field<int?>("ProductNumber");
            result.ProductIndex = row.Field<string>("ProductIndex");
            result.ProductName = row.Field<string>("ProductName");
            result.ProductAlias = row.Field<string>("ProductAlias");
            result.ApplicationId = row.Field<int?>("ApplicationId");
            if (result.ProductIndex == null) result.ProductIndex = string.Empty;
            if (result.ProductName == null) result.ProductName = string.Empty;
            if (result.ProductAlias == null) result.ProductAlias = string.Empty;
            if (result.ApplicationId == null) result.ApplicationId = -1;
            return result;
        }

        public static Product CreateFrom(CatalogItem catalogItem)
        {
            Product result = new Product();
            result.ApplicationId = catalogItem.ApplicationId;
            result.ProductNumber = catalogItem.ProductNumber;
            result.ProductIndex = catalogItem.ProductIndex;
            result.ProductAlias = catalogItem.ProductAlias;
            result.ProductName = catalogItem.ProductName;
            return result;
        }


        public static Product CreateFrom (ProductCatalogItem productCatalogItem)
        {
            Product result = new Product();
            result.ApplicationId = productCatalogItem.ApplicationId;
            result.ProductNumber = productCatalogItem.ProductNumber;
            result.ProductIndex = productCatalogItem.ProductIndex;
            result.ProductAlias = productCatalogItem.ProductAlias;
            result.ProductName = productCatalogItem.ProductName;
            return result;
        }

        public static Product CreateFrom(Product product)
        {
            Product result = new Product();
            result.ApplicationId = product.ApplicationId;
            result.ProductNumber = product.ProductNumber;
            result.ProductIndex = product.ProductIndex;
            result.ProductAlias = product.ProductAlias;
            result.ProductName = product.ProductName;
            return result;
        }


        Product() 
        {

        }

        public static Product Empty()
        {
            var result = new Product();
            result.IdInd = -1;
            result.ProductNumber = -1;
            result.ProductIndex = string.Empty;
            result.ProductName = string.Empty;
            result.ProductAlias = string.Empty;
            result.ApplicationId = -1;
            return result;
        }
        
        
        public int? IdInd { get; private set; }
        public int? ProductNumber { get; private set; }
        public string ProductIndex { get; private set; }
        public string ProductName { get; private set; }
        public string ProductAlias { get; private set; }
        public int? ApplicationId { get; private set; }


    }
}
