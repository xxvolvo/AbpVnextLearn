using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace yxyl.leanr.Data
{
    /* This is used if database provider does't define
     * IleanrDbSchemaMigrator implementation.
     */
    public class NullleanrDbSchemaMigrator : IleanrDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}