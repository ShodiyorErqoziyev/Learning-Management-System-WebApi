using LearningManagementSystem.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace LearningManagementSystem.WebApi.Configurations.LayerConfigurations;

public static class DataAccessConfiguration
{
    public static void ConfigureDataAccess(this WebApplicationBuilder builder)
    {
        string connectionString = builder.Configuration.GetConnectionString("DatabaseConnectionString")!;
        builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
    }
}
