using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMVCTask.Interface;
using WebAppMVCTask.Models;
using WebAppMVCTask.Repository;

namespace WebAppMVCTask.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserView()
        {
            List<Orders> orders = new List<Orders>();
            orders = _orderRepository.Display();
            return View(orders);
        }

        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Orders orders)
        {
            if (ModelState.IsValid)
            {
                _orderRepository.Insert(orders);
            }
            TempData["IsSaved"] = true;
            return RedirectToAction("Display");
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            OrderRepository sdb = new OrderRepository();
            return View(sdb.Display().Find(smodel => smodel.OrderId == id));
        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Orders orders)
        {
            try
            {
                _orderRepository.Updatedetail(orders);
                return RedirectToAction("Display");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Display()
        {
            List<Orders> orders = new List<Orders>();
            orders = _orderRepository.Display();
            return View(orders);
        }
        public ActionResult Delete(Orders orders)
        {
            _orderRepository.Deletedetail(orders);
            return RedirectToAction("Display");
        }
    }
}
