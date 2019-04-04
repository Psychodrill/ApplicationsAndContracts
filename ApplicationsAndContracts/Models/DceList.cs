using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.DataAccess;


namespace ApplicationsAndContracts.Models
{
    public class DceList:List<Dce>
    {
        public static DceList GetDceList()
        {
            var rows = new DataService().GetDceList();
            var list = rows.Select(row => Dce.CreateFrom(row));
            var result = new DceList(list);
            return result;
        }









        private DceList(IEnumerable<Dce>items): base(items)
        {

        }
    }
}
