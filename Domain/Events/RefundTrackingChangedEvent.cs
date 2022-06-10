using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
