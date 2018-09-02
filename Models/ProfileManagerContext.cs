using Microsoft.EntityFrameworkCore;

namespace ProfileManager.Models
{
    public class ProfileManagerContext : DbContext
    {
        public ProfileManagerContext(DbContextOptions<ProfileManagerContext> options)
                : base(options)
        {
        }

        public DbSet<Applicatie> Applicatie { get; set; }
        public DbSet<Gilde> Gilde { get; set; }
        public DbSet<Persoon> Persoon { get; set; }
        public DbSet<ScrumTeam> ScrumTeam { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Competentie> Competentie { get; set; }
    }
}