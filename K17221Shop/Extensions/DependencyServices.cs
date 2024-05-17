using BusinessObject.Constants;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace K17221Shop.Extensions
{
    public static class DependencyServices
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables(EnvironmentVariableConstant.Prefix).Build();
            services.AddDbContext<K17221shopContext>(options => options.UseSqlServer(CreateConnectionString(configuration)));
            return services;
        }

        private static string CreateConnectionString(IConfiguration configuration)
        {
            string connectionString =
                $"Server={configuration.GetValue<string>(DatabaseConstants.Host)};" +
                $"User Id={configuration.GetValue<string>(DatabaseConstants.UserName)};" +
                $"Password={configuration.GetValue<string>(DatabaseConstants.Password)};" +
                $"Database={configuration.GetValue<string>(DatabaseConstants.Database)}";
            return connectionString;
        }
    }
}
