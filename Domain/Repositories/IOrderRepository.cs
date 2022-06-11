namespace Domain.Repositories;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllOrders();
}
