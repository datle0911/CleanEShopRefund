namespace Application.Queries.Customers;

public class GetCustomerByIdQuery : IRequest<Customer>
{
    public int Id { get; set; }
    public GetCustomerByIdQuery(int id)
    {
        Id = id;
    }
}
