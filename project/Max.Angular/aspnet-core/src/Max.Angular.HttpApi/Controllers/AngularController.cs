using Max.Angular.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Max.Angular.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AngularController : AbpControllerBase
{
    protected AngularController()
    {
        LocalizationResource = typeof(AngularResource);
    }
}
