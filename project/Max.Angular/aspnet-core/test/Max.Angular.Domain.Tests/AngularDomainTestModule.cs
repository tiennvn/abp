using Volo.Abp.Modularity;

namespace Max.Angular;

[DependsOn(
    typeof(AngularDomainModule),
    typeof(AngularTestBaseModule)
)]
public class AngularDomainTestModule : AbpModule
{

}
