using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Wi.Max;

[Dependency(ReplaceServices = true)]
public class MaxBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Max";
}
