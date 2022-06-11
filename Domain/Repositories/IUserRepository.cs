namespace Domain.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsers();
}
