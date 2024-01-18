using Microsoft.EntityFrameworkCore;
using Starting_Blazor.Components.Games;

namespace Starting_Blazor.Components.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
        public DbSet<Game> Game_List { get; set; }
    }
}
