using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Hr.Management.Domain;

namespace Hr.Management.Persistence
{
    public static partial class PersistenceServicesRegistration
    {
        public class LeaveManagmentDbContextFactor : IDesignTimeDbContextFactory<LeaveManagmentDbContext>
        {
            public LeaveManagmentDbContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var builder = new DbContextOptionsBuilder<LeaveManagmentDbContext>();
                var connectionString = configuration.GetConnectionString("LeaveManagmentConnectionString");
                builder.UseSqlServer(connectionString);
                return new LeaveManagmentDbContext(builder.Options);
            }
        }
    }
}
