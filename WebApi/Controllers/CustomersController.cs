namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : Controller
{
    private readonly IMediator _mediator;
    public CustomersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET
    [HttpGet]
    public async Task<IActionResult> GetAllCustomers()
    {
        var result = _mediator.Send(new GetAllCustomersQuery());

        return Ok(result);
    }
}
