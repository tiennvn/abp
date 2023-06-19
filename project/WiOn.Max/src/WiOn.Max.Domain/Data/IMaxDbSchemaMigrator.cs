using System.Threading.Tasks;

namespace WiOn.Max.Data;

public interface IMaxDbSchemaMigrator
{
    Task MigrateAsync();
}
