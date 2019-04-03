using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationsAndContracts.Models
{
    public class Order
    {
        public static Order CreateFrom(DataRow row)
        {
            var result = new Order();
            result.ApplicationId = row.Field<int>("ApplicationId");
            result.OrderNumber = row.Field<int>("Order");
            return result;
        }



        public Order()
        {

        }

        public static Order Empty()
        {
            var result = new Order();
            result.ApplicationId = -1;
            result.OrderNumber = -1;
            return result;
        }

        public int ApplicationId { get; private set; }
        public int OrderNumber { get; private set; }
    }
}
