using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            Models.OrderService orderService = new Models.OrderService();
            Models.Order order = orderService.GetOrderById("1");
            ViewBag.CustId = order.CustId;
            ViewBag.CustName = order.CustName;
            return View();
        }

        public ActionResult Index2(string id)
        {
            ViewBag.id = id;
            return View();
        }

        public ActionResult InsertOrder()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order)
        {
            Models.OrderService orderService = new Models.OrderService();
            orderService.InsertOrder(order);
            return View("Index");
        }


    }
}