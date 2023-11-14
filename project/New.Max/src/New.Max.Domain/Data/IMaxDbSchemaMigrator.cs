using System.Threading.Tasks;

namespace New.Max.Data;

public interface IMaxDbSchemaMigrator
{
    Task MigrateAsync();
}
