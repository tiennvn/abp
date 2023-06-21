using System.Threading.Tasks;

namespace WiOn.Tizet.Data;

public interface ITizetDbSchemaMigrator
{
    Task MigrateAsync();
}
