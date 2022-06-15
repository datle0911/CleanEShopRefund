namespace WebApi.ViewModels.Refunds;

public class RefundViewModel
{
    public RefundViewModel()
    {

    }
    public RefundViewModel(DateTime timestamp, EPurchaseCode proportion, EStatus status)
    {
        Timestamp = timestamp;
        Proportion = proportion;
        Status = status;
    }

    public DateTime Timestamp { get; set; }
    public EPurchaseCode Proportion { get; set; }
    public EStatus Status { get; set; }
}
