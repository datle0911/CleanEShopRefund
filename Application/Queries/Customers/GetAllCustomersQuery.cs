namespace Application.Queries.Customers;

public record GetAllCustomersQuery : IRequest<IEnumerable<Customer>>;
