using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UnoSquareTest.Data.Repositories.Tasks;

namespace UnoSquareTest.Data
{
    public static class DataDependencyInjection
    {

        public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("UnoSquareTest.Data"));
            });

            services.AddScoped<ITasksRepository, TasksRepository>();

            return services;
        }

    }
}
