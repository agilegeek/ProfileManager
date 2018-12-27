using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ProfileManager.Models
{
    public class ProfileManagerContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ProfileManagerContext(DbContextOptions<ProfileManagerContext> options)
                : base(options)
        {
        }

        public DbSet<Applicatie> Applicaties { get; set; }
        public DbSet<Gilde> Gildes { get; set; }
        public DbSet<Persoon> Personen { get; set; }
        public DbSet<ScrumTeam> ScrumTeams { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Competentie> Competenties { get; set; }
        public DbSet<Locatie> Locaties { get; set;}
        public DbSet<Rol> Rollen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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

            // Persoon - Rol
            modelBuilder.Entity<PersoonRol>()
            .HasKey(pr => new { pr.PersoonId, pr.RolId });

            modelBuilder.Entity<PersoonRol>()
            .HasOne(pr => pr.Persoon)
            .WithMany(t => t.PersoonRollen)
            .HasForeignKey(pr => pr.PersoonId);

            modelBuilder.Entity<PersoonRol>()
            .HasOne(pr => pr.Rol)
            .WithMany(r => r.PersoonRollen)
            .HasForeignKey(pr => pr.RolId);

            modelBuilder.Entity<ApplicationUser>().Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}