using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace yxyl.leanr.Albums
{
    public interface ICategoryRepository : IRepository<Category, Guid>
    {
        Task<Category> GetByNameAsync(string name);
    }
}
