using Volo.Abp.Modularity;

namespace Max.Pos;

[DependsOn(
    typeof(PosApplicationModule),
    typeof(PosDomainTestModule)
)]
public class PosApplicationTestModule : AbpModule
{

}
