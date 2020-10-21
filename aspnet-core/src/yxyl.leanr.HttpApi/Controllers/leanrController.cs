using yxyl.leanr.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace yxyl.leanr.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class leanrController : AbpController
    {
        protected leanrController()
        {
            LocalizationResource = typeof(leanrResource);
        }
    }
}