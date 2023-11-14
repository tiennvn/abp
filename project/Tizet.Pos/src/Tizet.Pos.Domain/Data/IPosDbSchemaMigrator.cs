using System.Threading.Tasks;

namespace Tizet.Pos.Data;

public interface IPosDbSchemaMigrator
{
    Task MigrateAsync();
}
