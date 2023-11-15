using Volo.Abp.Modularity;

namespace Max.Angular;

[DependsOn(
    typeof(AngularApplicationModule),
    typeof(AngularDomainTestModule)
)]
public class AngularApplicationTestModule : AbpModule
{

}
