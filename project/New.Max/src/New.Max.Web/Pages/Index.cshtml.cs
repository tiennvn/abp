using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace New.Max.Web.Pages;

public class IndexModel : MaxPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
