namespace Domain.Repositories;

public interface IUserRepository
{
    Task AddUser(User user);
    Task<IEnumerable<User>> GetAllUsers();
}
