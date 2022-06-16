namespace Application.Commands.Users;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, User>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    public CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        await _userRepository.AddUser(request.User);
        await _unitOfWork.SaveChanges();
        return request.User;
    }
}
