using Volo.Abp.Modularity;

namespace Acme.ModularMonolith;

[DependsOn(
    typeof(ModularMonolithApplicationModule),
    typeof(ModularMonolithDomainTestModule)
)]
public class ModularMonolithApplicationTestModule : AbpModule
{

}
