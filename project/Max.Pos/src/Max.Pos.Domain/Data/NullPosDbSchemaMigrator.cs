using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Max.Pos.Data;

/* This is used if database provider does't define
 * IPosDbSchemaMigrator implementation.
 */
public class NullPosDbSchemaMigrator : IPosDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
