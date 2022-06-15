namespace WebApi.ViewModels.Customers;

public class SaveCustomerViewModel
{
    public SaveCustomerViewModel()
    {

    }
    public SaveCustomerViewModel(string userName, string passwords, string fullName, string phoneNumber, string email)
    {
        UserName = userName;
        Passwords = passwords;
        FullName = fullName;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public string UserName { get; set; }
    public string Passwords { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}
