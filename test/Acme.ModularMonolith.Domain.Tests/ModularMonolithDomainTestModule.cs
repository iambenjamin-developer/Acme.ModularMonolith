using Volo.Abp.Modularity;

namespace Acme.ModularMonolith;

[DependsOn(
    typeof(ModularMonolithDomainModule),
    typeof(ModularMonolithTestBaseModule)
)]
public class ModularMonolithDomainTestModule : AbpModule
{

}
