using WiOn.Tizet.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace WiOn.Tizet.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TizetEntityFrameworkCoreModule),
    typeof(TizetApplicationContractsModule)
    )]
public class TizetDbMigratorModule : AbpModule
{

}
