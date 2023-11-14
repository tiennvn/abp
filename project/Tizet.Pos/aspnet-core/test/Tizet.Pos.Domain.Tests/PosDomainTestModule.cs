using Volo.Abp.Modularity;

namespace Tizet.Pos;

[DependsOn(
    typeof(PosDomainModule),
    typeof(PosTestBaseModule)
)]
public class PosDomainTestModule : AbpModule
{

}
