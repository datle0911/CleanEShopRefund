namespace Application.Handlers;

public class OrderStatusChangedEventHandler : INotificationHandler<OrderStatusChangedEvent>
{
    public Task Handle(OrderStatusChangedEvent notification, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
