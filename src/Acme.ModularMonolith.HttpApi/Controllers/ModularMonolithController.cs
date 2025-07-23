using Acme.ModularMonolith.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.ModularMonolith.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ModularMonolithController : AbpControllerBase
{
    protected ModularMonolithController()
    {
        LocalizationResource = typeof(ModularMonolithResource);
    }
}
