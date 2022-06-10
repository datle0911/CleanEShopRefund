using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Orders;

public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, IEnumerable<Order>>
//{
//    private readonly IOrderRepository _orderRepository;
//    public GetAllOrdersQueryHandler(IOrderRepository orderRepository)
//    {
//        _orderRepository = orderRepository;
//    }

//    public async Task<IEnumerable<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
//    {
//        var orders = _orderRepository.GetAllOrders();

//        return orders;
//    }
}
