using MentorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.Data
{
    public class MentorAppDbContext:DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public MentorAppDbContext(DbContextOptions<MentorAppDbContext> options) : base(options)
        {

        }
    }
}
