using EternaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaApp.Data
{
    public class EternaDbContext:DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public EternaDbContext(DbContextOptions<EternaDbContext> options) : base(options)
        {
        }
    }
}
