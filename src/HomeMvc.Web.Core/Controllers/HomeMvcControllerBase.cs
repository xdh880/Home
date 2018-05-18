using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HomeMvc.Controllers
{
    public abstract class HomeMvcControllerBase: AbpController
    {
        protected HomeMvcControllerBase()
        {
            LocalizationSourceName = HomeMvcConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
