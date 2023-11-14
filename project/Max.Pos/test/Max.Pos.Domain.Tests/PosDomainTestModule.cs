using Volo.Abp.Modularity;

namespace Max.Pos;

[DependsOn(
    typeof(PosDomainModule),
    typeof(PosTestBaseModule)
)]
public class PosDomainTestModule : AbpModule
{

}
