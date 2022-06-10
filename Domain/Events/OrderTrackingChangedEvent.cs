namespace Domain.Events;

public class OrderTrackingChangedEvent : INotification
{
    public OrderTrackingChangedEvent(string id, ETracking tracking)
    {
        Id = id;
        Tracking = tracking;
    }

    public string Id { get; set; }
    public ETracking Tracking { get; set; }
}
