namespace Domain.Repositories;

public interface IOrderRepository
{
    Task AddOrder(Order order);
    Task<IEnumerable<Order>> GetAllOrders();
}
