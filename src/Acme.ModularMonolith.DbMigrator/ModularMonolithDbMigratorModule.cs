using Acme.ModularMonolith.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.ModularMonolith.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ModularMonolithEntityFrameworkCoreModule),
    typeof(ModularMonolithApplicationContractsModule)
    )]
public class ModularMonolithDbMigratorModule : AbpModule
{
}
