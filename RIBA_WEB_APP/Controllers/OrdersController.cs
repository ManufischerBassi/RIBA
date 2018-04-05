using RIBA_BASE_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RIBA_WEB_APP.Controllers
{


    
    public class OrdersController : Controller
    {
        public static List<Order> fakeOrders = new List<Order>{
                   new Order { Id = 1, customerName= "John Smith", quantity=5 ,orderDate = new DateTime(2017,1,1)},
                    new Order { Id = 2, customerName= "David shaw",quantity=15 ,orderDate = new DateTime(2017,2,15)},
                    new Order { Id = 3, customerName= "Tim Ellie",quantity=25 ,orderDate = new DateTime(2017,4,20)},
                   new Order { Id = 4, customerName= "Stuart Mike",quantity=40 ,orderDate = new DateTime(2017,11,30)},
                    new Order { Id = 5, customerName= "Andrew Johnson",quantity=10 ,orderDate = new DateTime(2018,1,1)},
                   new Order { Id = 6, customerName= "Mike Brown",quantity=30 ,orderDate = new DateTime(2017,8,10)},
                    new Order { Id = 7, customerName= "Robert Ayer",quantity=30 ,orderDate = new DateTime(2017,7,15)},
                    };

        // GET: Orders
        public ActionResult Index()
        {
           fakeOrders = fakeOrders.Where(k => (k.orderDate).Year == 2017).ToList();
             CalculateUtil cal = new CalculateUtil();
            foreach (Order item in fakeOrders)
            {
                item.price = cal.CalculateDiscount(item.price, item.quantity);
            }
            //return View(fakeOrders);
            // ascending order by date
            return View(fakeOrders.OrderBy(order => order.orderDate).ToList());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Order ord = new Order();
                ord.customerName = collection["customerName"];
                DateTime ordDate;
                DateTime.TryParse(collection["orderDate"], out ordDate);
                ord.orderDate = ordDate;
                string qty = collection["quantity"];
                ord.quantity= Int32.Parse(qty);
                ord.Id = fakeOrders.Count+1;
                fakeOrders.Add(ord);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Orders/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Orders/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
