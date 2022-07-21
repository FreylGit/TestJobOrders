using TestJobOrders.Data.InterfaceData;
using TestJobOrders.Models;

namespace TestJobOrders.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _repository;
        public IQueryable<Order> Orders => _repository.Orders;
        public OrderRepository(ApplicationDbContext repository)
        {
            _repository = repository;
        }
        

        public void AddOrder(Order order)
        {
            _repository.Orders.Add(order);
            _repository.SaveChanges();
        }

        public void RemoveOrder(Order order)
        {
            _repository.Orders.Remove(order);
        }

        public void UpdateOrder(Order order)
        {
            _repository.Orders.Update(order);
        }
    }
}
