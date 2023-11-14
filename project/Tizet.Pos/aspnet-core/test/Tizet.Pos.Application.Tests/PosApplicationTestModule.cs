using Volo.Abp.Modularity;

namespace Tizet.Pos;

[DependsOn(
    typeof(PosApplicationModule),
    typeof(PosDomainTestModule)
)]
public class PosApplicationTestModule : AbpModule
{

}
