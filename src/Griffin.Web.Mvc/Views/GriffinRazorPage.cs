using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Griffin.Web.Views
{
    public abstract class GriffinRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected GriffinRazorPage()
        {
            LocalizationSourceName = GriffinConsts.LocalizationSourceName;
        }
    }
}
