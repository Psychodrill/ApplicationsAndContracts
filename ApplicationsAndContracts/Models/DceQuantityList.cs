using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.Models;
using ApplicationsAndContracts.DataAccess;


namespace ApplicationsAndContracts.Models
{
    public  class DceQuantityList:List<DceQuantity>
    {
        public static DceQuantityList GetDceQuantityList()
        {
            var rows = new DataService().GetDceQuantityList();
            var list = rows.Select(row => DceQuantity.CreateFrom(row)).ToList();
            var result = new DceQuantityList(list);
            return result;
        }


        private DceQuantityList(IEnumerable<DceQuantity> items):base(items)
        {

        }

    }
}
