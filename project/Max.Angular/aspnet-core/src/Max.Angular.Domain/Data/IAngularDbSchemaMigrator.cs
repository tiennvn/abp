using System.Threading.Tasks;

namespace Max.Angular.Data;

public interface IAngularDbSchemaMigrator
{
    Task MigrateAsync();
}
