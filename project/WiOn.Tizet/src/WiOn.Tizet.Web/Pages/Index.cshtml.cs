using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace WiOn.Tizet.Web.Pages;

public class IndexModel : TizetPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
