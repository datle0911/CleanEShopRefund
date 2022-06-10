using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Events;

public class RefundTrackingChangedEvent : INotification
{
    public RefundTrackingChangedEvent(string id, ETracking tracking)
    {
        Id = id;
        Tracking = tracking;
    }

    public string Id { get; set; }
    public ETracking Tracking { get; set; }
}
