using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationsAndContracts.Models
{
    public class Supplier
    {
        public static Supplier CreateFrom (DataRow row)
        {
            var result = new Supplier();
            result.SupplierCode = row.Field<int>("SupplierCode");
            result.SupplierName = row.Field<string>("SupplierName");
            return result;
        }

        public static Supplier CreateFrom (ApplicationCatalogItem applicationCatalogItem)
        {
            var result = new Supplier();
            result.SupplierName = applicationCatalogItem.SupplierName;
            return result;
        }

        public static Supplier CreateFrom(SupplierCatalogItem supplierCatalogItem)
        {
            var result = new Supplier();
            result.SupplierName = supplierCatalogItem.SupplierName;
            return result;
        }

        public static Supplier CreateFrom(CatalogItem catalogItem)
        {
            var result = new Supplier();
            result.SupplierCode = catalogItem.SupplierCode;
            result.SupplierName = catalogItem.SupplierName;
            return result;
        }


        public Supplier()
        {

        }

        public static Supplier Empty()
        {
            var result = new Supplier();
            result.SupplierCode = -1;
            result.SupplierName = string.Empty;
            return result; 
        }

        public int SupplierCode { get; private set; }
        public string SupplierName { get; private set; }
    }
}
