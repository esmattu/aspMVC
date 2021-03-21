using Microsoft.EntityFrameworkCore;
using aspMVC.Models;

namespace aspMVC.Models.Movie.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
