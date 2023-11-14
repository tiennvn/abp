using Tizet.Pos.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Tizet.Pos.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class PosPageModel : AbpPageModel
{
    protected PosPageModel()
    {
        LocalizationResourceType = typeof(PosResource);
    }
}
