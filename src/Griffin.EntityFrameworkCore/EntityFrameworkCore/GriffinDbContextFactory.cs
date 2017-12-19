using Griffin.Configuration;
using Griffin.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Griffin.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class GriffinDbContextFactory : IDbContextFactory<GriffinDbContext>
    {
        public GriffinDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<GriffinDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            GriffinDbContextConfigurer.Configure(builder, configuration.GetConnectionString(GriffinConsts.ConnectionStringName));
            
            return new GriffinDbContext(builder.Options);
        }
    }
}