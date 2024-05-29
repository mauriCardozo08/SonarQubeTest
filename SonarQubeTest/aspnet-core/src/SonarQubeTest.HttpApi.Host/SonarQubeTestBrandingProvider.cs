using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SonarQubeTest;

[Dependency(ReplaceServices = true)]
public class SonarQubeTestBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SonarQubeTest";
}
