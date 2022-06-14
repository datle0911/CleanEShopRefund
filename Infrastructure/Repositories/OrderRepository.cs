namespace Infrastructure.Repositories;

public class OrderRepository : BaseRepository, IOrderRepository
{
    public OrderRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task AddOrder(Order order)
    {
        await _context.AddAsync(order);
    }

    public async Task<IEnumerable<Order>> GetAllOrders()
    {
        return await _context
            .Orders
            .Include(o => o.Customer)
            .AsNoTracking()
            .ToListAsync();
    }
}
