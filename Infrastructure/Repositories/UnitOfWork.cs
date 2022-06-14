using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories;

public class UnitOfWork : BaseRepository, IUnitOfWork
{
    public UnitOfWork(ApplicationDbContext context) : base(context)
    {
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}
