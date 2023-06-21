using WiOn.Tizet.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace WiOn.Tizet.Web.Pages;

public abstract class TizetPageModel : AbpPageModel
{
    protected TizetPageModel()
    {
        LocalizationResourceType = typeof(TizetResource);
    }
}
