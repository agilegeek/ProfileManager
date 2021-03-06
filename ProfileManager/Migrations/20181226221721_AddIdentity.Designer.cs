﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProfileManager.Models;

namespace ProfileManager.Migrations
{
    [DbContext(typeof(ProfileManagerContext))]
    [Migration("20181226221721_AddIdentity")]
    partial class AddIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProfileManager.Models.Applicatie", b =>
                {
                    b.Property<int>("ApplicatieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam");

                    b.Property<int?>("ScrumTeamId");

                    b.Property<string>("Technologie");

                    b.Property<string>("Versie");

                    b.HasKey("ApplicatieId");

                    b.HasIndex("ScrumTeamId");

                    b.ToTable("Applicaties");
                });

            modelBuilder.Entity("ProfileManager.Models.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("ProfileManager.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ProfileManager.Models.Competentie", b =>
                {
                    b.Property<int>("CompetentieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam");

                    b.Property<int?>("PersoonId");

                    b.HasKey("CompetentieId");

                    b.HasIndex("PersoonId");

                    b.ToTable("Competenties");
                });

            modelBuilder.Entity("ProfileManager.Models.Gilde", b =>
                {
                    b.Property<int>("GildeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LeadPersoonId");

                    b.Property<string>("Naam");

                    b.HasKey("GildeId");

                    b.HasIndex("LeadPersoonId");

                    b.ToTable("Gildes");
                });

            modelBuilder.Entity("ProfileManager.Models.Locatie", b =>
                {
                    b.Property<int>("LocatieId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kantoor");

                    b.Property<string>("Vestiging");

                    b.HasKey("LocatieId");

                    b.ToTable("Locaties");
                });

            modelBuilder.Entity("ProfileManager.Models.Persoon", b =>
                {
                    b.Property<int>("PersoonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Achternaam");

                    b.Property<string>("Functie");

                    b.Property<DateTime>("Geboortedatum");

                    b.Property<int?>("LocatieId");

                    b.Property<string>("TelefoonNummer");

                    b.Property<string>("Tussenvoegsel");

                    b.Property<string>("Voornaam");

                    b.HasKey("PersoonId");

                    b.HasIndex("LocatieId");

                    b.ToTable("Personen");
                });

            modelBuilder.Entity("ProfileManager.Models.PersoonGilde", b =>
                {
                    b.Property<int>("PersoonId");

                    b.Property<int>("GildeId");

                    b.HasKey("PersoonId", "GildeId");

                    b.HasIndex("GildeId");

                    b.ToTable("PersoonGilde");
                });

            modelBuilder.Entity("ProfileManager.Models.PersoonRol", b =>
                {
                    b.Property<int>("PersoonId");

                    b.Property<int>("RolId");

                    b.HasKey("PersoonId", "RolId");

                    b.HasIndex("RolId");

                    b.ToTable("PersoonRol");
                });

            modelBuilder.Entity("ProfileManager.Models.PersoonScrumTeam", b =>
                {
                    b.Property<int>("PersoonId");

                    b.Property<int>("ScrumTeamId");

                    b.HasKey("PersoonId", "ScrumTeamId");

                    b.HasIndex("ScrumTeamId");

                    b.ToTable("PersoonScrumTeam");
                });

            modelBuilder.Entity("ProfileManager.Models.PersoonTeam", b =>
                {
                    b.Property<int>("PersoonId");

                    b.Property<int>("TeamId");

                    b.HasKey("PersoonId", "TeamId");

                    b.HasIndex("TeamId");

                    b.ToTable("PersoonTeam");
                });

            modelBuilder.Entity("ProfileManager.Models.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beschrijving");

                    b.Property<string>("Naam");

                    b.HasKey("RolId");

                    b.ToTable("Rollen");
                });

            modelBuilder.Entity("ProfileManager.Models.ScrumTeam", b =>
                {
                    b.Property<int>("ScrumTeamId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beschrijving");

                    b.Property<int?>("LocatieId");

                    b.Property<string>("Naam");

                    b.Property<int?>("ProductownerPersoonId");

                    b.Property<int?>("ScrummasterPersoonId");

                    b.HasKey("ScrumTeamId");

                    b.HasIndex("LocatieId");

                    b.HasIndex("ProductownerPersoonId");

                    b.HasIndex("ScrummasterPersoonId");

                    b.ToTable("ScrumTeams");
                });

            modelBuilder.Entity("ProfileManager.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beschrijving");

                    b.Property<int?>("ManagerPersoonId");

                    b.Property<string>("Naam");

                    b.HasKey("TeamId");

                    b.HasIndex("ManagerPersoonId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("ProfileManager.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ProfileManager.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ProfileManager.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("ProfileManager.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProfileManager.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ProfileManager.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProfileManager.Models.Applicatie", b =>
                {
                    b.HasOne("ProfileManager.Models.ScrumTeam")
                        .WithMany("Applicaties")
                        .HasForeignKey("ScrumTeamId");
                });

            modelBuilder.Entity("ProfileManager.Models.Competentie", b =>
                {
                    b.HasOne("ProfileManager.Models.Persoon")
                        .WithMany("Competenties")
                        .HasForeignKey("PersoonId");
                });

            modelBuilder.Entity("ProfileManager.Models.Gilde", b =>
                {
                    b.HasOne("ProfileManager.Models.Persoon", "Lead")
                        .WithMany()
                        .HasForeignKey("LeadPersoonId");
                });

            modelBuilder.Entity("ProfileManager.Models.Persoon", b =>
                {
                    b.HasOne("ProfileManager.Models.Locatie", "Locatie")
                        .WithMany()
                        .HasForeignKey("LocatieId");
                });

            modelBuilder.Entity("ProfileManager.Models.PersoonGilde", b =>
                {
                    b.HasOne("ProfileManager.Models.Gilde", "Gilde")
                        .WithMany("PersoonGildes")
                        .HasForeignKey("GildeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProfileManager.Models.Persoon", "Persoon")
                        .WithMany("PersoonGildes")
                        .HasForeignKey("PersoonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProfileManager.Models.PersoonRol", b =>
                {
                    b.HasOne("ProfileManager.Models.Persoon", "Persoon")
                        .WithMany("PersoonRollen")
                        .HasForeignKey("PersoonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProfileManager.Models.Rol", "Rol")
                        .WithMany("PersoonRollen")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProfileManager.Models.PersoonScrumTeam", b =>
                {
                    b.HasOne("ProfileManager.Models.Persoon", "Persoon")
                        .WithMany("PersoonScrumTeams")
                        .HasForeignKey("PersoonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProfileManager.Models.ScrumTeam", "ScrumTeam")
                        .WithMany("PersoonScrumTeams")
                        .HasForeignKey("ScrumTeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProfileManager.Models.PersoonTeam", b =>
                {
                    b.HasOne("ProfileManager.Models.Persoon", "Persoon")
                        .WithMany("PersoonTeams")
                        .HasForeignKey("PersoonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProfileManager.Models.Team", "Team")
                        .WithMany("PersoonTeams")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProfileManager.Models.ScrumTeam", b =>
                {
                    b.HasOne("ProfileManager.Models.Locatie", "Locatie")
                        .WithMany()
                        .HasForeignKey("LocatieId");

                    b.HasOne("ProfileManager.Models.Persoon", "Productowner")
                        .WithMany()
                        .HasForeignKey("ProductownerPersoonId");

                    b.HasOne("ProfileManager.Models.Persoon", "Scrummaster")
                        .WithMany()
                        .HasForeignKey("ScrummasterPersoonId");
                });

            modelBuilder.Entity("ProfileManager.Models.Team", b =>
                {
                    b.HasOne("ProfileManager.Models.Persoon", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerPersoonId");
                });
#pragma warning restore 612, 618
        }
    }
}
