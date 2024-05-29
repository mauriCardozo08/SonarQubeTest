using Volo.Abp.Modularity;

namespace SonarQubeTest;

[DependsOn(
    typeof(SonarQubeTestDomainModule),
    typeof(SonarQubeTestTestBaseModule)
)]
public class SonarQubeTestDomainTestModule : AbpModule
{

}
