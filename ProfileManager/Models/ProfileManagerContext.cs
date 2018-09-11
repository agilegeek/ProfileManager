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
        public DbSet<Locatie> Locatie { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Persoon - Gilde
            modelBuilder.Entity<PersoonGilde>()
            .HasKey(pg => new { pg.PersoonId, pg.GildeId });

            modelBuilder.Entity<PersoonGilde>()
            .HasOne(pg => pg.Persoon)
            .WithMany(p => p.PersoonGildes)
            .HasForeignKey(pg => pg.PersoonId);

            modelBuilder.Entity<PersoonGilde>()
            .HasOne(pg => pg.Gilde)
            .WithMany(g => g.PersoonGildes)
            .HasForeignKey(pg => pg.GildeId);

            // Persoon - ScrumTeam
            modelBuilder.Entity<PersoonScrumTeam>()
            .HasKey(ps => new { ps.PersoonId, ps.ScrumTeamId });

            modelBuilder.Entity<PersoonScrumTeam>()
            .HasOne(ps => ps.Persoon)
            .WithMany(s => s.PersoonScrumTeams)
            .HasForeignKey(ps => ps.PersoonId);

            modelBuilder.Entity<PersoonScrumTeam>()
            .HasOne(ps => ps.ScrumTeam)
            .WithMany(s => s.PersoonScrumTeams)
            .HasForeignKey(ps => ps.ScrumTeamId);

             // Persoon - Team
            modelBuilder.Entity<PersoonTeam>()
            .HasKey(pt => new { pt.PersoonId, pt.TeamId });

            modelBuilder.Entity<PersoonTeam>()
            .HasOne(pt => pt.Persoon)
            .WithMany(t => t.PersoonTeams)
            .HasForeignKey(pt => pt.PersoonId);

            modelBuilder.Entity<PersoonTeam>()
            .HasOne(pt => pt.Team)
            .WithMany(t => t.PersoonTeams)
            .HasForeignKey(pt => pt.TeamId);
        }
    }
}