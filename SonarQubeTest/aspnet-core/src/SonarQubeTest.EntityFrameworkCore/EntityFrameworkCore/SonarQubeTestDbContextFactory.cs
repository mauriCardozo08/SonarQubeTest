using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SonarQubeTest.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SonarQubeTestDbContextFactory : IDesignTimeDbContextFactory<SonarQubeTestDbContext>
{
    public SonarQubeTestDbContext CreateDbContext(string[] args)
    {
        SonarQubeTestEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SonarQubeTestDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SonarQubeTestDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SonarQubeTest.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
