namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : Controller
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public UsersController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var result = await _mediator.Send(new GetAllUsersQuery());

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(SaveUserViewModel saveUserViewModel)
    {
        var resource = _mapper.Map<SaveUserViewModel, User>(saveUserViewModel);
        var result = await _mediator.Send(new CreateUserCommand(resource));
        return Ok(result);
    }
}
