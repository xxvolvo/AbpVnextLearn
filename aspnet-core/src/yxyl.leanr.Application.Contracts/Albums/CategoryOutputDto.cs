using System;
using Volo.Abp.Application.Dtos;

namespace yxyl.leanr.Albums
{

    public class CategoryOutputDto : EntityDto<Guid>
    {
        public string CategoryName { get; set; }
    }
}
