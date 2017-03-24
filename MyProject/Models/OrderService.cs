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

        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <param name="Id">訂單ID</param>
        /// <returns></returns>
        public Models.Order GetOrderById(string Id)
        {
            Models.Order result = new Order();
            result.CustId = "GSS";
            result.CustName = "叡揚資訊";
            return result;
        }

        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrders()
        {
            List<Models.Order> result = new List<Order>();
            result.Add(new Models.Order() { CustId="GSS",CustName="叡揚資訊",EmpId=1,EmpName="王小明",Orderdate=DateTime.Parse("2015/11/08")});
            result.Add(new Models.Order() { CustId="NPOIS",CustName="網軟資訊",EmpId=2,EmpName="李小華",Orderdate=DateTime.Parse("2015/11/01")});
            return result;
        }
    }
}