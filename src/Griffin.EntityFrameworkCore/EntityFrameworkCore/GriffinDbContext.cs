using Abp.Zero.EntityFrameworkCore;
using Griffin.Authorization.Roles;
using Griffin.Authorization.Users;
using Griffin.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Griffin.EntityFrameworkCore
{
    public class GriffinDbContext : AbpZeroDbContext<Tenant, Role, User, GriffinDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public GriffinDbContext(DbContextOptions<GriffinDbContext> options)
            : base(options)
        {

        }
    }
}
