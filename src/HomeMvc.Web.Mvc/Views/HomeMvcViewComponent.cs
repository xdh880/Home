using Abp.AspNetCore.Mvc.ViewComponents;

namespace HomeMvc.Web.Views
{
    public abstract class HomeMvcViewComponent : AbpViewComponent
    {
        protected HomeMvcViewComponent()
        {
            LocalizationSourceName = HomeMvcConsts.LocalizationSourceName;
        }
    }
}
