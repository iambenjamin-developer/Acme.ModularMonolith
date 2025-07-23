using Acme.ModularMonolith.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.ModularMonolith.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ModularMonolithPageModel : AbpPageModel
{
    protected ModularMonolithPageModel()
    {
        LocalizationResourceType = typeof(ModularMonolithResource);
    }
}
