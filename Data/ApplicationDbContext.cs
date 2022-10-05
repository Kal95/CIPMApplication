using CIPMApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CIPMApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Students> Students { get; set; }

        public DbSet<CorpMembers> CorpMembers { get; set; }
        public DbSet<Corporates> Corporates { get; set; }

        public DbSet<Practitionals> Practitionals { get; set; }
    }
}
