using WiOn.Max.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace WiOn.Max;

[DependsOn(
    typeof(MaxEntityFrameworkCoreTestModule)
    )]
public class MaxDomainTestModule : AbpModule
{

}
