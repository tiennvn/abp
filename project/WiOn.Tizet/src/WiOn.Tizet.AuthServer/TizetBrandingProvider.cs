using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace WiOn.Tizet;

[Dependency(ReplaceServices = true)]
public class TizetBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Tizet";
}
