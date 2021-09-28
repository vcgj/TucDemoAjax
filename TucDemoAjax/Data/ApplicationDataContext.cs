using Microsoft.EntityFrameworkCore;

namespace TucDemoAjax.Data
{
    public class ApplicationDataContext
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {

            }

            public DbSet<Team> Teams { get; set; }
            public DbSet<Game> Games { get; set; }
        }

    }
}