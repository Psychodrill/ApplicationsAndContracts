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
            result.StructureQuantityId = row.Field<int>("StructureQuantityId");
            result.ApplicationId = row.Field<int>("ApplicationId");
            result.ProductStructureId = row.Field<int?>("ProductStructureId");
            result.DceStructureId = row.Field<int?>("DceStructureId");
            result.ProductDceQuantity = row.Field<decimal>("Quantity");
            return result;
        }

        internal static DceQuantity CreateFrom(CatalogItem catalogItem)
        {
            var result = new DceQuantity();
            result.StructureQuantityId = catalogItem.StructureQuantityId;
            result.ApplicationId = catalogItem.ApplicationId;
            result.ProductStructureId = catalogItem.ProductStructureId;
            result.DceStructureId = catalogItem.DceStructureId;
            result.ProductDceQuantity = catalogItem.ProductDceQuantity;
            return result;
        }

        internal static DceQuantity CreateFrom(DceQuantity dceQuantity)
        {
            var result = new DceQuantity();
            result.StructureQuantityId = dceQuantity.StructureQuantityId;
            result.ApplicationId = dceQuantity.ApplicationId;
            result.ProductStructureId = dceQuantity.ProductStructureId;
            result.DceStructureId = dceQuantity.DceStructureId;
            result.ProductDceQuantity = dceQuantity.ProductDceQuantity;
            return result;

        }



        public int StructureQuantityId { get; private set; } 
        public int ApplicationId { get; private set; }
        public int? ProductStructureId { get; private set; }
        public int? DceStructureId { get; private set; }


        public decimal ProductDceQuantity { get; private set; }
    }
}
