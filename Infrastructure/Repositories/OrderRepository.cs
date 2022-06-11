namespace Infrastructure.Repositories;

public class OrderRepository : BaseRepository, IOrderRepository
{
    public OrderRepository(ApplicationDbContext context) : base(context)
    {
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
