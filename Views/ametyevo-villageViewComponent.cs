using Abp.AspNetCore.Mvc.ViewComponents;

namespace ametyevo-village.Web.Views
{
    public abstract class ametyevo-villageViewComponent : AbpViewComponent
    {
        protected ametyevo-villageViewComponent()
        {
            LocalizationSourceName = ametyevo-villageConsts.LocalizationSourceName;
        }
    }
}
