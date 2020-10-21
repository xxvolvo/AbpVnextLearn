using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace yxyl.leanr.Albums
{
    public class CategoryService : ApplicationService, ICategoryService
    {
        private readonly ICategoryRepository categories;

        public CategoryService(ICategoryRepository categories)
        {
            this.categories = categories;
        }

        public async Task<CategoryOutputDto> GetByName(string name)
        {
            var model = await this.categories.GetByNameAsync(name);
            var result = new CategoryOutputDto
            {
                Id = model.Id,
                CategoryName = model.CategoryName
            };
            return result;
        }

        public async Task<CategoryOutputDto> CreateAsync()
        {
            var model = new Category
            {
                CategoryName = DateTime.Now.ToString()
            };
            await this.categories.InsertAsync(model);
            var result = new CategoryOutputDto
            {
                Id = model.Id,
                CategoryName = model.CategoryName
            };
            return result;
        }
    }
}

