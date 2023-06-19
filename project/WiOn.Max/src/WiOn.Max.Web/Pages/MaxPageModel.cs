using WiOn.Max.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace WiOn.Max.Web.Pages;

public abstract class MaxPageModel : AbpPageModel
{
    protected MaxPageModel()
    {
        LocalizationResourceType = typeof(MaxResource);
    }
}
