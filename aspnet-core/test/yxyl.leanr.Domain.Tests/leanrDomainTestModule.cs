using yxyl.leanr.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace yxyl.leanr
{
    [DependsOn(
        typeof(leanrEntityFrameworkCoreTestModule)
        )]
    public class leanrDomainTestModule : AbpModule
    {

    }
}