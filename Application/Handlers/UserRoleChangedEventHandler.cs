namespace Application.Handlers;

public class UserRoleChangedEventHandler : INotificationHandler<UserRoleChangedEvent>
{
    public Task Handle(UserRoleChangedEvent notification, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
