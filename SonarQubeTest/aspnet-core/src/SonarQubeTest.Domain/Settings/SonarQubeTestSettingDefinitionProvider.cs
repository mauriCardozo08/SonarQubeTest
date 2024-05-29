using Volo.Abp.Settings;

namespace SonarQubeTest.Settings;

public class SonarQubeTestSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SonarQubeTestSettings.MySetting1));
    }
}
