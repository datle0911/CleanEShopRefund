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
        //var result = await _mediator.Send(new GetAllCustomersQuery());
        var result = _context.Customers.ToList();
        return Ok(result);
    }
}
