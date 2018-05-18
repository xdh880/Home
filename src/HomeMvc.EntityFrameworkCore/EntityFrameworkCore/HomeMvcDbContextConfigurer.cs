using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HomeMvc.EntityFrameworkCore
{
    public static class HomeMvcDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HomeMvcDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HomeMvcDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
