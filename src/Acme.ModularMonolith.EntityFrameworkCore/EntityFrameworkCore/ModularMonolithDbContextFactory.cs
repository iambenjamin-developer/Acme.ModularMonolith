using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.ModularMonolith.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ModularMonolithDbContextFactory : IDesignTimeDbContextFactory<ModularMonolithDbContext>
{
    public ModularMonolithDbContext CreateDbContext(string[] args)
    {
        ModularMonolithEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ModularMonolithDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ModularMonolithDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.ModularMonolith.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
