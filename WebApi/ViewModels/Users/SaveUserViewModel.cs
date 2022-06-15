namespace WebApi.ViewModels.Users;

public class SaveUserViewModel
{
    public SaveUserViewModel()
    {

    }
    public SaveUserViewModel(string userName, string passwords, string fullName, string phoneNumber, ERole role)
    {
        UserName = userName;
        Passwords = passwords;
        FullName = fullName;
        PhoneNumber = phoneNumber;
        Role = role;
    }

    public string UserName { get; set; }
    public string Passwords { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public ERole Role { get; set; }
}
