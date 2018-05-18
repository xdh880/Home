using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HomeMvc.Configuration;

namespace HomeMvc.Web.Host.Startup
{
    [DependsOn(
       typeof(HomeMvcWebCoreModule))]
    public class HomeMvcWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HomeMvcWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HomeMvcWebHostModule).GetAssembly());
        }
    }
}
