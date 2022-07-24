using Microsoft.AspNetCore.Mvc;
using TestJobOrders.Data.InterfaceData;
using TestJobOrders.Models.ViewModel;

namespace TestJobOrders.Controllers
{
    public class ListController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private int _countItem = 2;

        public ListController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;

        }

        public IActionResult Index(int page = 1)
        {

            ListOrderViewModel list = new ListOrderViewModel()
            {
                Orders = _orderRepository.Orders.Skip((page - 1) * _countItem).Take(_countItem),
                PageInfo = new PageInfo()
                {
                    CurrentPage = page,
                    CountItems = _countItem,

                }
            };
            return View(list);
        }
    }
}

