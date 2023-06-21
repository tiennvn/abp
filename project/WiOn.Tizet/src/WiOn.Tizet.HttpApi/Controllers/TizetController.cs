using WiOn.Tizet.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace WiOn.Tizet.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TizetController : AbpControllerBase
{
    protected TizetController()
    {
        LocalizationResource = typeof(TizetResource);
    }
}
