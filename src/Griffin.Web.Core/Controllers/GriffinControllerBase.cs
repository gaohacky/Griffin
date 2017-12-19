using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Griffin.Controllers
{
    public abstract class GriffinControllerBase: AbpController
    {
        protected GriffinControllerBase()
        {
            LocalizationSourceName = GriffinConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}