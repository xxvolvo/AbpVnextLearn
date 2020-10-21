using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace yxyl.leanr.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class leanrMigrationsDbContextFactory : IDesignTimeDbContextFactory<leanrMigrationsDbContext>
    {
        public leanrMigrationsDbContext CreateDbContext(string[] args)
        {
            leanrEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<leanrMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new leanrMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../yxyl.leanr.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
