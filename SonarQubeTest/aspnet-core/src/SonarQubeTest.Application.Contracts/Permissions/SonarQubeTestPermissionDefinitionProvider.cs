using SonarQubeTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SonarQubeTest.Permissions;

public class SonarQubeTestPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SonarQubeTestPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SonarQubeTestPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SonarQubeTestResource>(name);
    }
}
