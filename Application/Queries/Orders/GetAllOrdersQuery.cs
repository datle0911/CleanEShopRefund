namespace Application.Queries.Orders;

public record GetAllOrdersQuery : IRequest<IEnumerable<Order>>;
