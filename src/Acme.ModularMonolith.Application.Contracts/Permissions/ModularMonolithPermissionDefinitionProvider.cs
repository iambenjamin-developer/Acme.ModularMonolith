using Acme.ModularMonolith.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.ModularMonolith.Permissions;

public class ModularMonolithPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ModularMonolithPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ModularMonolithPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ModularMonolithResource>(name);
    }
}
