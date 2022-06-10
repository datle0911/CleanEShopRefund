namespace Application.Handlers;

public class OrderTrackingChangedEventHandler : INotificationHandler<OrderTrackingChangedEvent>
{
    public Task Handle(OrderTrackingChangedEvent notification, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
