namespace Application.Handlers;

public class RefundTrackingChangedEventHandler : INotificationHandler<RefundTrackingChangedEvent>
{
    public Task Handle(RefundTrackingChangedEvent notification, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
