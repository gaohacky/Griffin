using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Griffin.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Griffin.Web.Host.Startup
{
    [DependsOn(
       typeof(GriffinWebCoreModule))]
    public class GriffinWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GriffinWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GriffinWebHostModule).GetAssembly());
        }
    }
}
