using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Max.Angular;

[Dependency(ReplaceServices = true)]
public class AngularBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Angular";
}
