namespace Domain.Events;

public class OrderStatusChangedEvent : INotification
{
    public OrderStatusChangedEvent(string id, EStatus status)
    {
        Id = id;
        Status = status;
    }

    public string Id { get; set; }
    public EStatus Status { get; set; }
}
