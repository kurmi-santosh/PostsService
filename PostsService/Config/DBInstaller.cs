using System;
using Microsoft.EntityFrameworkCore;
using PostsService.Database;

namespace PostsService.Config
{
    public class DBInstaller : IInstaller
    {
        public void InstallService(IServiceCollection services, IConfiguration configuration)
        {
            var database = configuration["Database"] ?? "Posts";
            var server = configuration["DBServer"] ?? "sql-server";
            var port = configuration["DBPort"] ?? "1433";
            var userName = configuration["UserName"] ?? "SA";
            var password = configuration["Password"] ?? "MySQLPassw0rd";
            var connectionString = $"Server={server},{port};Initial Catalog={database};User ID={userName};Password={password}";

            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
        }
    }
}

