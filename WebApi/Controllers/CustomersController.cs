using Infrastructure.DbContexts;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : Controller
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public CustomersController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }


    // GET
    [HttpGet]
    public async Task<IActionResult> GetAllCustomers()
    {
        var result = await _mediator.Send(new GetAllCustomersQuery());

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _mediator.Send(new GetCustomerByIdQuery(id));

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomer(SaveCustomerViewModel saveCustomerViewModel)
    {
        var resource = _mapper.Map<SaveCustomerViewModel, Customer>(saveCustomerViewModel);
        var result = await _mediator.Send(new CreateCustomerCommand(resource));
        return Ok(result);
    }
}
