using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace WiOn.Tizet.Data;

/* This is used if database provider does't define
 * ITizetDbSchemaMigrator implementation.
 */
public class NullTizetDbSchemaMigrator : ITizetDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
