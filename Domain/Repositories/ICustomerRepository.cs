namespace Domain.Repositories;

public interface ICustomerRepository
{
    Task AddCustomer(Customer customer);
    Task<IEnumerable<Customer>> GetAllCustomers();
    Task<Customer?> GetCustomerById(int id);
}
