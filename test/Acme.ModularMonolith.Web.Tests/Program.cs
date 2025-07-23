using Microsoft.AspNetCore.Builder;
using Acme.ModularMonolith;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();

builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Acme.ModularMonolith.Web.csproj");
await builder.RunAbpModuleAsync<ModularMonolithWebTestModule>(applicationName: "Acme.ModularMonolith.Web" );

public partial class Program
{
}
