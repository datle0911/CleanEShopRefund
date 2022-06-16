namespace WebApi.ViewModels.Orders;

public class OrderViewModel
{
    public OrderViewModel()
    {

    }

    public OrderViewModel(string id, CustomerViewModel customer, RefundViewModel refund, DateTime timestamp, string address, EStatus status, ETracking tracking, string purchaseCode, double totalPrice)
    {
        Id = id;
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
    public CustomerViewModel Customer { get; set; } = new CustomerViewModel();
    public RefundViewModel Refund { get; set; } = new RefundViewModel();
    public DateTime Timestamp { get; set; }
    public string Address { get; set; }
    public EStatus Status { get; set; }
    public ETracking Tracking { get; set; }
    public string PurchaseCode { get; set; }
    public double TotalPrice { get; set; }
}
