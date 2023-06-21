using Volo.Abp.Modularity;

namespace WiOn.Tizet;

[DependsOn(
    typeof(TizetApplicationModule),
    typeof(TizetDomainTestModule)
    )]
public class TizetApplicationTestModule : AbpModule
{

}
