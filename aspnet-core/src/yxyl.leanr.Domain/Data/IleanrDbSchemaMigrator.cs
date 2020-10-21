using System.Threading.Tasks;

namespace yxyl.leanr.Data
{
    public interface IleanrDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
