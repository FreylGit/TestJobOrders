namespace TestJobOrders.Models.ViewModel
{
    public class ListOrderViewModel
    {
        public PageInfo PageInfo { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
