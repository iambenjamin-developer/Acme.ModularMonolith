﻿using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.ModularMonolith.Data;

/* This is used if database provider does't define
 * IModularMonolithDbSchemaMigrator implementation.
 */
public class NullModularMonolithDbSchemaMigrator : IModularMonolithDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
