using Volo.Abp.Modularity;

namespace New.Max;

[DependsOn(
    typeof(MaxApplicationModule),
    typeof(MaxDomainTestModule)
)]
public class MaxApplicationTestModule : AbpModule
{

}
