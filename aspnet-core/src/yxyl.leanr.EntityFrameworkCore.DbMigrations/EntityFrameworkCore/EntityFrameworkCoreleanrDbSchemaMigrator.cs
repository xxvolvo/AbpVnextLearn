using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using yxyl.leanr.Data;
using Volo.Abp.DependencyInjection;

namespace yxyl.leanr.EntityFrameworkCore
{
    public class EntityFrameworkCoreleanrDbSchemaMigrator
        : IleanrDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreleanrDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the leanrMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<leanrMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}