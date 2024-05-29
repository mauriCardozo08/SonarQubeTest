using SonarQubeTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SonarQubeTest.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SonarQubeTestEntityFrameworkCoreModule),
    typeof(SonarQubeTestApplicationContractsModule)
    )]
public class SonarQubeTestDbMigratorModule : AbpModule
{
}
