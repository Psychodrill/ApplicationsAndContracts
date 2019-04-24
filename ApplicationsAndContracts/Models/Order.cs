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
            result.OrderNumber = row.Field<int>("OrderNumber");
            result.SetFrom = row.Field<int>("SetFrom");
            result.SetTo = row.Field<int>("SetTo");
            return result;
        }


        public static Order CreateFrom(Order order)
        {
            Order result = new Order();
            result.ApplicationId = order.ApplicationId;
            result.OrderNumber = order.OrderNumber;
            result.SetFrom = order.SetFrom;
            result.SetTo = order.SetTo;
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
        public int SetFrom { get; private set; }
        public int SetTo { get; private set; }
    }
}
