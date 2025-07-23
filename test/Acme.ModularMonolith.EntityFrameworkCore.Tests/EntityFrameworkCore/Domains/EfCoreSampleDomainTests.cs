using Acme.ModularMonolith.Samples;
using Xunit;

namespace Acme.ModularMonolith.EntityFrameworkCore.Domains;

[Collection(ModularMonolithTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ModularMonolithEntityFrameworkCoreTestModule>
{

}
