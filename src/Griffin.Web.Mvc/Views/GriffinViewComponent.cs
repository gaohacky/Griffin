using Abp.AspNetCore.Mvc.ViewComponents;

namespace Griffin.Web.Views
{
    public abstract class GriffinViewComponent : AbpViewComponent
    {
        protected GriffinViewComponent()
        {
            LocalizationSourceName = GriffinConsts.LocalizationSourceName;
        }
    }
}