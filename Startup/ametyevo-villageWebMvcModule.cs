using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ametyevo-village.Configuration;

namespace ametyevo-village.Web.Startup
{
    [DependsOn(typeof(ametyevo-villageWebCoreModule))]
    public class ametyevo-villageWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ametyevo-villageWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<ametyevo-villageNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ametyevo-villageWebMvcModule).GetAssembly());
        }
    }
}
