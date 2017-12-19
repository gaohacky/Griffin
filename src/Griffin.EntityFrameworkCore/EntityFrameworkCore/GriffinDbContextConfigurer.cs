using Microsoft.EntityFrameworkCore;

namespace Griffin.EntityFrameworkCore
{
    public static class GriffinDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GriffinDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}