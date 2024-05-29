using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SonarQubeTest.Data;

/* This is used if database provider does't define
 * ISonarQubeTestDbSchemaMigrator implementation.
 */
public class NullSonarQubeTestDbSchemaMigrator : ISonarQubeTestDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
