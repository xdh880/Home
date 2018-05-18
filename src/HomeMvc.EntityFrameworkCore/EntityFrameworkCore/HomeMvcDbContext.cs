using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HomeMvc.Authorization.Roles;
using HomeMvc.Authorization.Users;
using HomeMvc.MultiTenancy;

namespace HomeMvc.EntityFrameworkCore
{
    public class HomeMvcDbContext : AbpZeroDbContext<Tenant, Role, User, HomeMvcDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HomeMvcDbContext(DbContextOptions<HomeMvcDbContext> options)
            : base(options)
        {
        }
    }
}
