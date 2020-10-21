using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace yxyl.leanr.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(leanrHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class leanrConsoleApiClientModule : AbpModule
    {
        
    }
}
