using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Max.Pos.Web.Pages;

public class IndexModel : PosPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
