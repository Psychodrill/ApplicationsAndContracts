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
            result.IdInd = row.Field<int>("IdInd");
            result.ProductNumber = row.Field<int>("ProductId");
            result.ProductIndex = row.Field<string>("ProductIndex");
            result.ProductName = row.Field<string>("ProductName");
            result.ProductAlias = row.Field<string>("ProductAlias");
            result.ApplicationId = row.Field<int?>("ApplicationId");
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
        
        
        public int IdInd { get; private set; }
        public int ProductNumber { get; private set; }
        public string ProductIndex { get; private set; }
        public string ProductName { get; private set; }
        public string ProductAlias { get; private set; }
        public int? ApplicationId { get; private set; }


    }
}
