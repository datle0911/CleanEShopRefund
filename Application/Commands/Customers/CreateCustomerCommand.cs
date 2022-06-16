namespace Application.Commands.Customers;

public record CreateCustomerCommand(Customer Customer) : IRequest<Customer>
{
    public CreateCustomerCommand(Customer customer, int id, string userName, string passwords, string fullName, string phoneNumber, string email) : this(customer)
    {
        Id = id;
        UserName = userName;
        Passwords = passwords;
        FullName = fullName;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public int Id { get; set; }
    public string UserName { get; set; }
    public string Passwords { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}
