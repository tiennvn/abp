using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace WiOn.Max.Data;

/* This is used if database provider does't define
 * IMaxDbSchemaMigrator implementation.
 */
public class NullMaxDbSchemaMigrator : IMaxDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
