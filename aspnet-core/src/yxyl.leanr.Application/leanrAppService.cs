using System;
using System.Collections.Generic;
using System.Text;
using yxyl.leanr.Localization;
using Volo.Abp.Application.Services;

namespace yxyl.leanr
{
    /* Inherit your application services from this class.
     */
    public abstract class leanrAppService : ApplicationService
    {
        protected leanrAppService()
        {
            LocalizationResource = typeof(leanrResource);
        }
    }
}
