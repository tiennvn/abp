using Tizet.Pos.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Tizet.Pos.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PosEntityFrameworkCoreModule),
    typeof(PosApplicationContractsModule)
    )]
public class PosDbMigratorModule : AbpModule
{
}
