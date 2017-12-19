using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Griffin.Authorization;

namespace Griffin
{
    [DependsOn(
        typeof(GriffinCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GriffinApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GriffinAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(GriffinApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}