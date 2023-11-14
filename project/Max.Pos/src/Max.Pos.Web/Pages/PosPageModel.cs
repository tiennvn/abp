using Max.Pos.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Max.Pos.Web.Pages;

public abstract class PosPageModel : AbpPageModel
{
    protected PosPageModel()
    {
        LocalizationResourceType = typeof(PosResource);
    }
}
