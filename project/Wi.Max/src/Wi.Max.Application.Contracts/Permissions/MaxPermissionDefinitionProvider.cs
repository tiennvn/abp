﻿using Wi.Max.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Wi.Max.Permissions;

public class MaxPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MaxPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MaxPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MaxResource>(name);
    }
}
