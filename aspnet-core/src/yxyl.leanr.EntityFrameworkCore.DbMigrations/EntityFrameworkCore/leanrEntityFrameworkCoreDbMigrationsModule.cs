using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace yxyl.leanr.EntityFrameworkCore
{
    [DependsOn(
        typeof(leanrEntityFrameworkCoreModule)
        )]
    public class leanrEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<leanrMigrationsDbContext>();
        }
    }
}
