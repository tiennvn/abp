using System.Threading.Tasks;

namespace Max.Pos.Data;

public interface IPosDbSchemaMigrator
{
    Task MigrateAsync();
}
