namespace Domain.Models;

public class Refund
{
    public Refund()
    {

    }

    public Refund(string orderId, DateTime timestamp, EPurchaseCode proportion, EStatus status)
    {
        OrderId = orderId;
        Timestamp = timestamp;
        Proportion = proportion;
        Status = status;
    }

    public string OrderId { get; set; }
    public DateTime Timestamp { get; set; }
    public EPurchaseCode Proportion { get; set; }
    public EStatus Status { get; set; }
}
