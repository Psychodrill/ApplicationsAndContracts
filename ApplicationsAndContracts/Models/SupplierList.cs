using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ApplicationsAndContracts.DataAccess;
using ApplicationsAndContracts.Helpers;


namespace ApplicationsAndContracts.Models
{
    public class SupplierList:List<Supplier>
    {

        public static SupplierList GetSupplierList()
        {
            var rows = new DataService().GetSupplierList();

            var list = rows.Select(row => Supplier.CreateFrom(row)).ToList();
            var result = new SupplierList(list);
            return result;
        }
        public Supplier GetSupplier(string supplierName)
        {
            if (supplierName == string.Empty) return Supplier.Empty();
            var result = this.FirstOrDefault(x => x.SupplierName == supplierName);
            if (result!= null) return result;
            throw new ApplicationException(string.Format(Resources.SupplierIsOutOfRangeText, supplierName));
        }


        public Supplier TryGetSupplier (string supplierName)
        {
            try
            {
                return GetSupplier(supplierName);
            }
            catch (ApplicationException)
            {
                return Supplier.Empty();
            }
        }
        private SupplierList(IEnumerable<Supplier> items) : base(items)
        {

        }
    }
}
