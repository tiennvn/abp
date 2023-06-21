using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WiOn.Tizet.Data;
using Volo.Abp.DependencyInjection;

namespace WiOn.Tizet.EntityFrameworkCore;

public class EntityFrameworkCoreTizetDbSchemaMigrator
    : ITizetDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTizetDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TizetDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TizetDbContext>()
            .Database
            .MigrateAsync();
    }
}
