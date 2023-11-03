using Volo.Abp.Modularity;

namespace Wi.Max;

[DependsOn(
    typeof(MaxApplicationModule),
    typeof(MaxDomainTestModule)
    )]
public class MaxApplicationTestModule : AbpModule
{

}
