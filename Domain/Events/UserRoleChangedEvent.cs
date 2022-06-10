namespace Domain.Events;

public class UserRoleChangedEvent : INotification
{
    public UserRoleChangedEvent(int id, ERole role)
    {
        Id = id;
        Role = role;
    }

    public int Id { get; set; }
    public ERole Role { get; set; }
}
