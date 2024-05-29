using System.Threading.Tasks;

namespace SonarQubeTest.Data;

public interface ISonarQubeTestDbSchemaMigrator
{
    Task MigrateAsync();
}
