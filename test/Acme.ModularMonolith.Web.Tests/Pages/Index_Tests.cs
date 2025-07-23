using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.ModularMonolith.Pages;

public class Index_Tests : ModularMonolithWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
