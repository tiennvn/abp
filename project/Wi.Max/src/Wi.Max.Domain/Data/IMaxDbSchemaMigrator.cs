using System.Threading.Tasks;

namespace Wi.Max.Data;

public interface IMaxDbSchemaMigrator
{
    Task MigrateAsync();
}
