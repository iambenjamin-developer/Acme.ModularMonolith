﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.ModularMonolith.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.ModularMonolith.EntityFrameworkCore;

public class EntityFrameworkCoreModularMonolithDbSchemaMigrator
    : IModularMonolithDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreModularMonolithDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ModularMonolithDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ModularMonolithDbContext>()
            .Database
            .MigrateAsync();
    }
}
