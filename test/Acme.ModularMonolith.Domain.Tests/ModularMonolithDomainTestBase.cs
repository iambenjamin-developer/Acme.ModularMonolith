using Volo.Abp.Modularity;

namespace Acme.ModularMonolith;

/* Inherit from this class for your domain layer tests. */
public abstract class ModularMonolithDomainTestBase<TStartupModule> : ModularMonolithTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
