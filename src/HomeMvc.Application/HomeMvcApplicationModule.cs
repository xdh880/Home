using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HomeMvc.Authorization;

namespace HomeMvc
{
    [DependsOn(
        typeof(HomeMvcCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HomeMvcApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HomeMvcAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HomeMvcApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
