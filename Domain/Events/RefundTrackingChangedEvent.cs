namespace Domain.Events;

public class RefundTrackingChangedEvent : INotification
{
    public RefundTrackingChangedEvent(string orderId, ETracking tracking)
    {
        OrderId = orderId;
        Tracking = tracking;
    }

    public string OrderId { get; set; }
    public ETracking Tracking { get; set; }
}
