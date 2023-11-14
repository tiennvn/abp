using Max.Pos.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Max.Pos.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PosController : AbpControllerBase
{
    protected PosController()
    {
        LocalizationResource = typeof(PosResource);
    }
}
