using System;
using System.Collections.Generic;
using System.Text;
using Acme.ModularMonolith.Localization;
using Volo.Abp.Application.Services;

namespace Acme.ModularMonolith;

/* Inherit your application services from this class.
 */
public abstract class ModularMonolithAppService : ApplicationService
{
    protected ModularMonolithAppService()
    {
        LocalizationResource = typeof(ModularMonolithResource);
    }
}
