using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ametyevo-village.Web.Views
{
    public abstract class ametyevo-villageRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ametyevo-villageRazorPage()
        {
            LocalizationSourceName = ametyevo-villageConsts.LocalizationSourceName;
        }
    }
}
