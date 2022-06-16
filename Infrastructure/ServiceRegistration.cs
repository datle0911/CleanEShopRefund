using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ServiceRegistration
{
    public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), builder =>
            builder.MigrationsAssembly("WebApi")
        ));

        #region Add Repositories

        services.AddTransient<ICustomerRepository, CustomerRepository>();
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient(typeof(IUserRepository), typeof(UserRepository));
        services.AddTransient<IOrderRepository, OrderRepository>();
        services.AddTransient(typeof(IOrderRepository), typeof(OrderRepository));

        services.AddTransient<IUnitOfWork, UnitOfWork>();

        #endregion
    }
}
