using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Wi.Max.Data;
using Volo.Abp.DependencyInjection;

namespace Wi.Max.EntityFrameworkCore;

public class EntityFrameworkCoreMaxDbSchemaMigrator
    : IMaxDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMaxDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the MaxDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MaxDbContext>()
            .Database
            .MigrateAsync();
    }
}
