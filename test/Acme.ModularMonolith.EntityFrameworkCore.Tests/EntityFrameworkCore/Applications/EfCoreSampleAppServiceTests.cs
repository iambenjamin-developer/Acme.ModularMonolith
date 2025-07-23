using Acme.ModularMonolith.Samples;
using Xunit;

namespace Acme.ModularMonolith.EntityFrameworkCore.Applications;

[Collection(ModularMonolithTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ModularMonolithEntityFrameworkCoreTestModule>
{

}
