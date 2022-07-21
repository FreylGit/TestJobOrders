using Microsoft.AspNetCore.Mvc;
using TestJobOrders.Data.InterfaceData;
using TestJobOrders.Models.ViewModel;

namespace TestJobOrders.Controllers
{
    public class ListController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        public ListController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IActionResult Index()
        {
            ListOrderViewModel list = new ListOrderViewModel();
            list.Orders = _orderRepository.Orders;

            return View(list);
        }
    }
}
