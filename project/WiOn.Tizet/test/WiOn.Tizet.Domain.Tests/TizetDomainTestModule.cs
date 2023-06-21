using WiOn.Tizet.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace WiOn.Tizet;

[DependsOn(
    typeof(TizetEntityFrameworkCoreTestModule)
    )]
public class TizetDomainTestModule : AbpModule
{

}
