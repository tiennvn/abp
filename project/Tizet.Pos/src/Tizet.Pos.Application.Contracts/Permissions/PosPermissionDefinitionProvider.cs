using Tizet.Pos.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Tizet.Pos.Permissions;

public class PosPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PosPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PosPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PosResource>(name);
    }
}
