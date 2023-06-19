using Volo.Abp.Modularity;

namespace WiOn.Max;

[DependsOn(
    typeof(MaxApplicationModule),
    typeof(MaxDomainTestModule)
    )]
public class MaxApplicationTestModule : AbpModule
{

}
