using yxyl.leanr.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace yxyl.leanr.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(leanrEntityFrameworkCoreDbMigrationsModule),
        typeof(leanrApplicationContractsModule)
        )]
    public class leanrDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
