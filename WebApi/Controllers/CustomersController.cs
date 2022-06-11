using Infrastructure.DbContexts;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : Controller
{
    private readonly IMediator _mediator;
    private readonly ApplicationDbContext _context;
    public CustomersController(IMediator mediator, ApplicationDbContext context)
    {
        _mediator = mediator;
        _context = context;
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
}
