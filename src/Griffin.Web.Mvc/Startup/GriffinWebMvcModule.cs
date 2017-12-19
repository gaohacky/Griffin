using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Griffin.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Griffin.Web.Startup
{
    [DependsOn(typeof(GriffinWebCoreModule))]
    public class GriffinWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GriffinWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<GriffinNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GriffinWebMvcModule).GetAssembly());
        }
    }
}