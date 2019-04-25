using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ApplicationsAndContracts.Models;

namespace ApplicationsAndContracts.Models
{
    public class DceQuantity
    {
        public static DceQuantity CreateFrom(DataRow row)
        {
            var result = new DceQuantity();
            result.ApplicationId = row.Field<int>("ApplicationId");
            
            result.Quantity = row.Field<decimal>("Quantity");
            return result;
        }

        internal static DceQuantity CreateFrom(CatalogItem catalogItem)
        {
            var result = new DceQuantity();
            result.ApplicationId = catalogItem.ApplicationId;
            
            result.Quantity = catalogItem.Quantity;
            return result;
        }

        internal static DceQuantity CreateFrom(DceQuantity dceQuantity)
        {
            var result = new DceQuantity();
            result.ApplicationId = dceQuantity.ApplicationId;
            result.Quantity = dceQuantity.Quantity;
            return result;

        }




        public int ApplicationId { get; private set; }


        public decimal Quantity { get; private set; }
    }
}
