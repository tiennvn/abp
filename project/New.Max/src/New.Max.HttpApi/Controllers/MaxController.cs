using New.Max.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace New.Max.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MaxController : AbpControllerBase
{
    protected MaxController()
    {
        LocalizationResource = typeof(MaxResource);
    }
}
