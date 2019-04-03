using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ApplicationsAndContracts.DataAccess;
using ApplicationsAndContracts.Helpers;

namespace ApplicationsAndContracts.Models
{
    public class OrderList:List<Order>
    {
        public static OrderList GetOrderList()
        {
            var rows = new DataService().GetOrderList();

            var list = rows.Select(row => Order.CreateFrom(row)).ToList();
            var result = new OrderList(list);
            return result;
        }
        public Order GetOrder(int orderNumber)
        {
            if (orderNumber == -1) return Order.Empty();
            var result = this.FirstOrDefault(x => x.OrderNumber == orderNumber);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.OrderIsOutOfRangeText, orderNumber));
        }


        public Order TryGetOrder(int orderNumber)
        {
            try
            {
                return GetOrder(orderNumber);
            }
            catch (ApplicationException)
            {
                return Order.Empty();
            }
        }
        private OrderList(IEnumerable<Order> items) : base(items)
        {

        }
    }
}
