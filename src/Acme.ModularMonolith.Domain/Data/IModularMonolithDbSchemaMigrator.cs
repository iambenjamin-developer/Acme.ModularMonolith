using System.Threading.Tasks;

namespace Acme.ModularMonolith.Data;

public interface IModularMonolithDbSchemaMigrator
{
    Task MigrateAsync();
}
