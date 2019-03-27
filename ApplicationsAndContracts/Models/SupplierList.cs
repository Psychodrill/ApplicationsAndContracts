using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ApplicationsAndContracts.DataAccess;






namespace ApplicationsAndContracts.Models
{
    public class SupplierList:List<Supplier>
    {

        public static SupplierList GetSupplierList()
        {
            var rows = new DataService().GetSupplierList();
            var list = rows.Select(row => Supplier.CreateFrom(row)).ToList();
            var result = new SupplierList();
            return result;
        }
        private SupplierList() : base()
        {

        }
    }
}
