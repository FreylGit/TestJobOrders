using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestJobOrders.Data.InterfaceData;
using TestJobOrders.Models;

namespace TestJobOrders.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOrderRepository _orderRepository;

        public HomeController(ILogger<HomeController> logger,IOrderRepository orderRepository)
        {
            _logger = logger;
            _orderRepository = orderRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Order());
        }
        [HttpPost]
        public IActionResult Index(Order order)
        {
            if (ModelState.IsValid)
            {
                _orderRepository.AddOrder(order);
                return RedirectToAction("Thanks");
            }
            else
            {
                return View(order);
            }
        }
        public IActionResult Thanks()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}