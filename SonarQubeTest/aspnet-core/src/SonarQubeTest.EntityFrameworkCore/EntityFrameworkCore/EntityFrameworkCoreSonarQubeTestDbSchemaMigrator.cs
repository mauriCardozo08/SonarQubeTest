using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SonarQubeTest.Data;
using Volo.Abp.DependencyInjection;

namespace SonarQubeTest.EntityFrameworkCore;

public class EntityFrameworkCoreSonarQubeTestDbSchemaMigrator
    : ISonarQubeTestDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSonarQubeTestDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the SonarQubeTestDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SonarQubeTestDbContext>()
            .Database
            .MigrateAsync();
    }
}
