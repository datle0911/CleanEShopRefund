namespace Domain.Models;

public class User
{
    public User()
    {

    }

    public User(int id, string userName, string passwords, string fullName, string phoneNumber, ERole role)
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
