using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class OrderService
    {
        public void InsertOrder(Models.Order order)
        {

        }


        public void DeleteOrderById()
        {

        }

        public void UpdateOrder()
        {

        }

        public Models.Order GetOrderById(string Id)
        {
            Models.Order result = new Order();
            result.CustId = "GSS";
            result.CustName = "叡揚資訊";
            return result;
        }

        public List<Models.Order> GetOrders()
        {
            return new List<Order>();
        }
    }
}