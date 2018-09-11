﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProfileManager.Models;

namespace ProfileManager.Migrations
{
    [DbContext(typeof(ProfileManagerContext))]
    partial class ProfileManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("ProfileManager.Models.Applicatie", b =>
                {
                    b.Property<int>("ApplicatieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naam");

                    b.Property<int?>("ScrumTeamId");

                    b.Property<string>("Technologie");

                    b.Property<string>("Versie");

                    b.HasKey("ApplicatieId");

                    b.HasIndex("ScrumTeamId");

                    b.ToTable("Applicatie");
                });

            modelBuilder.Entity("ProfileManager.Models.Competentie", b =>
                {
                    b.Property<int>("CompetentieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naam");

                    b.Property<int?>("PersoonId");

                    b.HasKey("CompetentieId");

                    b.HasIndex("PersoonId");

                    b.ToTable("Competentie");
                });

            modelBuilder.Entity("ProfileManager.Models.Gilde", b =>
                {
                    b.Property<int>("GildeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LeadPersoonId");

                    b.Property<string>("Naam");

                    b.HasKey("GildeId");

                    b.HasIndex("LeadPersoonId");

                    b.ToTable("Gilde");
                });

            modelBuilder.Entity("ProfileManager.Models.Persoon", b =>
                {
                    b.Property<int>("PersoonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achternaam");

                    b.Property<string>("Functie");

                    b.Property<DateTime>("Geboortedatum");

                    b.Property<string>("Tussenvoegsel");

                    b.Property<string>("Voornaam");

                    b.HasKey("PersoonId");

                    b.ToTable("Persoon");
                });

            modelBuilder.Entity("ProfileManager.Models.PersoonGilde", b =>
                {
                    b.Property<int>("PersoonId");

                    b.Property<int>("GildeId");

                    b.HasKey("PersoonId", "GildeId");

                    b.HasIndex("GildeId");

                    b.ToTable("PersoonGilde");
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

            modelBuilder.Entity("ProfileManager.Models.ScrumTeam", b =>
                {
                    b.Property<int>("ScrumTeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naam");

                    b.Property<int?>("ProductownerPersoonId");

                    b.Property<int?>("ScrummasterPersoonId");

                    b.HasKey("ScrumTeamId");

                    b.HasIndex("ProductownerPersoonId");

                    b.HasIndex("ScrummasterPersoonId");

                    b.ToTable("ScrumTeam");
                });

            modelBuilder.Entity("ProfileManager.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ManagerPersoonId");

                    b.Property<string>("Naam");

                    b.HasKey("TeamId");

                    b.HasIndex("ManagerPersoonId");

                    b.ToTable("Team");
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