using Wi.Max.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Wi.Max;

[DependsOn(
    typeof(MaxEntityFrameworkCoreTestModule)
    )]
public class MaxDomainTestModule : AbpModule
{

}
