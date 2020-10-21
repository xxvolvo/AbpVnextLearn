using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using yxyl.leanr.EntityFrameworkCore;

namespace yxyl.leanr.Albums
{
    public class CategoryRepository : EfCoreRepository<leanrDbContext, Category, Guid>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<leanrDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Category> GetByNameAsync(string name)
        {
            return await DbSet.FirstOrDefaultAsync(g => g.CategoryName.Contains(name));
        }
    }
}
