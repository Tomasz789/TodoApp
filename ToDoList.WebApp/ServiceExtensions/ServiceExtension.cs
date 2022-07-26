using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TodoApp.DAL.DataContext;
using TodoApp.DAL.Wrappers;
using TodoApp.Repositories.Repositories;


namespace ToDoList.WebApp.ServiceExtension
{
    public static class ServiceExtension
    {
        public static void ConfigureSqlServerConnection(this IServiceCollection services, IConfiguration config)
        {
            var connString = config["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<AppDatabaseContext>(opt => opt.UseSqlServer(connString, a => a.MigrationsAssembly("ToDoList.WebApp")));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

    }
}
