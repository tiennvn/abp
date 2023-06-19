using WiOn.Max.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace WiOn.Max.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MaxEntityFrameworkCoreModule),
    typeof(MaxApplicationContractsModule)
    )]
public class MaxDbMigratorModule : AbpModule
{

}
