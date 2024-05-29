using Volo.Abp.Modularity;

namespace SonarQubeTest;

public abstract class SonarQubeTestApplicationTestBase<TStartupModule> : SonarQubeTestTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
