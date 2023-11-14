using Volo.Abp.Modularity;

namespace New.Max;

[DependsOn(
    typeof(MaxDomainModule),
    typeof(MaxTestBaseModule)
)]
public class MaxDomainTestModule : AbpModule
{

}
