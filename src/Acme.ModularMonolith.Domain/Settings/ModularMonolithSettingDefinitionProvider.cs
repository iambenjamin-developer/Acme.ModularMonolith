﻿using Volo.Abp.Settings;

namespace Acme.ModularMonolith.Settings;

public class ModularMonolithSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ModularMonolithSettings.MySetting1));
    }
}
