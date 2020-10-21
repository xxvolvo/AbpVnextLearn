using Volo.Abp.Modularity;

namespace yxyl.leanr
{
    [DependsOn(
        typeof(leanrApplicationModule),
        typeof(leanrDomainTestModule)
        )]
    public class leanrApplicationTestModule : AbpModule
    {

    }
}