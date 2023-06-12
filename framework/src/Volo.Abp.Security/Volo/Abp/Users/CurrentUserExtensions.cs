using System;
using System.Diagnostics;
using JetBrains.Annotations;
using Volo.Abp.Security.Claims;

namespace Volo.Abp.Users;

public static class CurrentUserExtensions
{
    [CanBeNull]
    public static string FindClaimValue(this ICurrentUser currentUser, string claimType)
    {
        return currentUser.FindClaim(claimType)?.Value;
    }

    public static T FindClaimValue<T>(this ICurrentUser currentUser, string claimType)
        where T : struct
    {
        var value = currentUser.FindClaimValue(claimType);
        if (value == null)
        {
            return default;
        }

        return value.To<T>();
    }

    public static string GetId(this ICurrentUser currentUser)
    {
        Debug.Assert(currentUser.Id != null, "currentUser.Id != null");

        return currentUser.Id;
    }

    public static string FindImpersonatorTenantId([NotNull] this ICurrentUser currentUser)
    {
        var impersonatorTenantId = currentUser.FindClaimValue(AbpClaimTypes.ImpersonatorTenantId);
        if (impersonatorTenantId.IsNullOrWhiteSpace())
        {
            return null;
        }

        return impersonatorTenantId;
    }

    public static string FindImpersonatorUserId([NotNull] this ICurrentUser currentUser)
    {
        var impersonatorUserId = currentUser.FindClaimValue(AbpClaimTypes.ImpersonatorUserId);
        if (impersonatorUserId.IsNullOrWhiteSpace())
        {
            return null;
        }

        return impersonatorUserId;
    }

    public static string FindImpersonatorTenantName([NotNull] this ICurrentUser currentUser)
    {
        return currentUser.FindClaimValue(AbpClaimTypes.ImpersonatorTenantName);
    }

    public static string FindImpersonatorUserName([NotNull] this ICurrentUser currentUser)
    {
        return currentUser.FindClaimValue(AbpClaimTypes.ImpersonatorUserName);
    }
}
