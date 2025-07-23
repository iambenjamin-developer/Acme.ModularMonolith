using Microsoft.Extensions.Localization;
using Acme.ModularMonolith.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.ModularMonolith.Web;

[Dependency(ReplaceServices = true)]
public class ModularMonolithBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ModularMonolithResource> _localizer;

    public ModularMonolithBrandingProvider(IStringLocalizer<ModularMonolithResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
