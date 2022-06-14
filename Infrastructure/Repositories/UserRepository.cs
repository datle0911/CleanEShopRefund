using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories;

public class UserRepository : BaseRepository, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task AddUser(User user)
    {
        await _context.AddAsync(user);
    }

    public async Task<IEnumerable<User>> GetAllUsers()
    {
        return await _context
            .Users
            .AsNoTracking()
            .ToListAsync();
    }
}
