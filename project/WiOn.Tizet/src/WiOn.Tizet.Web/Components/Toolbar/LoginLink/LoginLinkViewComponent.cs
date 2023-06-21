using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace WiOn.Tizet.Web.Components.Toolbar.LoginLink;

public class LoginLinkViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Components/Toolbar/LoginLink/Default.cshtml");
    }
}
