using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace yxyl.leanr.Albums
{
    public interface ICategoryService : IApplicationService
    {
        Task<CategoryOutputDto> GetByName(string name);
    }
}
