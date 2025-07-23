using Xunit;

namespace Acme.ModularMonolith.EntityFrameworkCore;

[CollectionDefinition(ModularMonolithTestConsts.CollectionDefinitionName)]
public class ModularMonolithEntityFrameworkCoreCollection : ICollectionFixture<ModularMonolithEntityFrameworkCoreFixture>
{

}
