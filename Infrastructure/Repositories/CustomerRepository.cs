namespace Infrastructure.Repositories;

public class CustomerRepository : BaseRepository, ICustomerRepository
{
    public CustomerRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Customer>> GetAllCustomers()
    {
        var customers = await _context
            .Customers
            .AsNoTracking()
            .ToListAsync();

        return customers;
    }

    public async Task<Customer?> GetCustomerById(int id)
    {
        var customer = _context
            .Customers
            .FirstOrDefault(c => c.Id == id);

        return customer;
    }
}
