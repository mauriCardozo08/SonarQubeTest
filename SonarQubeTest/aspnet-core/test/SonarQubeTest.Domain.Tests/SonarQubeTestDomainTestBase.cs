using Volo.Abp.Modularity;

namespace SonarQubeTest;

/* Inherit from this class for your domain layer tests. */
public abstract class SonarQubeTestDomainTestBase<TStartupModule> : SonarQubeTestTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
