using Volo.Abp.Modularity;

namespace Acme.ModularMonolith;

public abstract class ModularMonolithApplicationTestBase<TStartupModule> : ModularMonolithTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
