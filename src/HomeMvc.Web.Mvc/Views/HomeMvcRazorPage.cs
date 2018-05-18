using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace HomeMvc.Web.Views
{
    public abstract class HomeMvcRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected HomeMvcRazorPage()
        {
            LocalizationSourceName = HomeMvcConsts.LocalizationSourceName;
        }
    }
}
