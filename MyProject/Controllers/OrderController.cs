﻿using System;
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
            /* Models.OrderService orderService = new Models.OrderService();
             Models.Order order = orderService.GetOrderById("1");
             ViewBag.CustId = order.CustId;
             ViewBag.CustName = order.CustName;*/

            /*  ViewBag.Desc1 = "Hello ViewBag";
              ViewData["Desc2"] = "Hello ViewData";
              TempData["Desc3"] = "Hello TempData";*/

            //ViewBag.test = "2";

            /*  Models.OrderService orderService = new Models.OrderService();
              ViewBag.Data = orderService.GetOrders();*/

            List<SelectListItem> custData = new List<SelectListItem>();
            custData.Add(new SelectListItem()
            {
                Text="叡揚資訊",
                Value="1"
            });

            custData.Add(new SelectListItem()
            {
                Text = "網軟資訊",
                Value="2"
            });

            ViewBag.custData = custData;
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
            //      Models.OrderService orderService = new Models.OrderService();
            //     orderService.InsertOrder(order);
           /* ViewBag.Desc1 = "Hello ViewBag";
            ViewData["Desc2"] = "Hello ViewData";
            TempData["Desc3"] = "Hello TempData";
              return RedirectToAction("Index");*/
            //   return View("Index");
            return View();
        }

        [HttpGet()]
        public JsonResult TestJson()
        {
            // var result = new Models.Order();
            //result.CustId = "GSS";
            //result.CustName = "叡揚資訊";

            var result = new Models.Order() { CustId ="GSS",CustName= "叡揚資訊" };
            return this.Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}