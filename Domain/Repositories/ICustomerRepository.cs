namespace Domain.Repositories;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetAllCustomers();
    Task<Customer?> GetCustomerById(int id);
}
