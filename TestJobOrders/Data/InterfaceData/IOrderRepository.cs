using TestJobOrders.Models;

namespace TestJobOrders.Data.InterfaceData
{
    public interface IOrderRepository
    {
        public IQueryable<Order> Orders { get; }
        public void AddOrder(Order order);
        public void UpdateOrder(Order order);
        public void RemoveOrder(Order order);

    }
}
