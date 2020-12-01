using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;

namespace DAL
{
    public class AppContext : DbContext
    {
        public AppContext() : base(Connection()) { }

        private static DbContextOptions<AppContext> Connection()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySQL("server=localhost;database=cris;user=root;password=;port=3306");
            return optionsBuilder.Options;
        }

        public DbSet<Cardapios> Cardapios { get; set; }
        //public DbSet<Cardapios> Categories { get; set; }
       
    }
}
