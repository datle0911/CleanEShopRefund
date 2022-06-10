namespace Domain.Models;

public class Order
{
    public Order()
    {

    }

    public Order(string id, int customerId, Customer customer, Refund refund, DateTime timestamp, string address, EStatus status, ETracking tracking, string purchaseCode, double totalPrice)
    {
        Id = id;
        CustomerId = customerId;
        Customer = customer;
        Refund = refund;
        Timestamp = timestamp;
        Address = address;
        Status = status;
        Tracking = tracking;
        PurchaseCode = purchaseCode;
        TotalPrice = totalPrice;
    }

    public string Id { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public Refund Refund { get; set; }
    public DateTime Timestamp { get; set; }
    public string Address { get; set; }
    public EStatus Status { get; set; }
    public ETracking Tracking { get; set; }
    public string PurchaseCode { get; set; }
    public double TotalPrice { get; set; }
}
