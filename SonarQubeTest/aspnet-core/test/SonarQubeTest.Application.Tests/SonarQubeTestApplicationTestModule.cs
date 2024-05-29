using Volo.Abp.Modularity;

namespace SonarQubeTest;

[DependsOn(
    typeof(SonarQubeTestApplicationModule),
    typeof(SonarQubeTestDomainTestModule)
)]
public class SonarQubeTestApplicationTestModule : AbpModule
{

}
