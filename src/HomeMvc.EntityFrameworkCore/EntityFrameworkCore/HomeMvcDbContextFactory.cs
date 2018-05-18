using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HomeMvc.Configuration;
using HomeMvc.Web;

namespace HomeMvc.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HomeMvcDbContextFactory : IDesignTimeDbContextFactory<HomeMvcDbContext>
    {
        public HomeMvcDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HomeMvcDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HomeMvcDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HomeMvcConsts.ConnectionStringName));

            return new HomeMvcDbContext(builder.Options);
        }
    }
}
