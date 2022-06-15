namespace WebApi.ViewModels.Users;

public class UserViewModel
{
    public UserViewModel()
    {

    }
    public UserViewModel(int id, string userName, string passwords, string fullName, string phoneNumber, ERole role)
    {
        Id = id;
        UserName = userName;
        Passwords = passwords;
        FullName = fullName;
        PhoneNumber = phoneNumber;
        Role = role;
    }

    public int Id { get; set; }
    public string UserName { get; set; }
    public string Passwords { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public ERole Role { get; set; }
}
