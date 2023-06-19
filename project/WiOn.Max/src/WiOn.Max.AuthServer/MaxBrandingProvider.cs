using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace WiOn.Max;

[Dependency(ReplaceServices = true)]
public class MaxBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Max";
}
