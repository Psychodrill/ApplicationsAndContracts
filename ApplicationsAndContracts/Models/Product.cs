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

        }





        Product() 
       {

       }










        public int IdInd { get; private set; }

        public int ProductId { get; private set; }

        public int ProductIndex { get; private set; }

        public string ProductName { get; private set; }

        public string ProductAlias { get; private set; }

        public int ApplicationId { get; private set; }


    }
}
