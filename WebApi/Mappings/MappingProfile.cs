namespace WebApi.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Order Mapped
        CreateMap<Order, OrderViewModel>();
        CreateMap<OrderViewModel, Order>();

        // Save Order Mapped
        CreateMap<Order, SaveOrderViewModel>();
        CreateMap<SaveOrderViewModel, Order>();

        // Customer Mapped
        CreateMap<Customer, CustomerViewModel>();
        CreateMap<CustomerViewModel, Customer>();

        // Save Customer Mapped
        CreateMap<Customer, SaveCustomerViewModel>();
        CreateMap<SaveCustomerViewModel, Customer>();

        // Refund Mapped
        CreateMap<Refund, RefundViewModel>();
        CreateMap<RefundViewModel, Refund>();

        // Save Refund Mapped
        CreateMap<Refund, SaveRefundViewModel>();
        CreateMap<SaveRefundViewModel, Refund>();

        // User Mapped
        CreateMap<User, UserViewModel>();
        CreateMap<UserViewModel, User>();

        // Save User Mapped
        CreateMap<User, SaveUserViewModel>();
        CreateMap<SaveUserViewModel, User>();
    }
}
