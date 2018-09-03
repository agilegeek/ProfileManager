using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileManager.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persoon",
                columns: table => new
                {
                    PersoonId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Voornaam = table.Column<string>(nullable: true),
                    Achternaam = table.Column<string>(nullable: true),
                    Tussenvoegsel = table.Column<string>(nullable: true),
                    Geboortedatum = table.Column<DateTime>(nullable: false),
                    Functie = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persoon", x => x.PersoonId);
                });

            migrationBuilder.CreateTable(
                name: "Competentie",
                columns: table => new
                {
                    CompetentieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(nullable: true),
                    PersoonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competentie", x => x.CompetentieId);
                    table.ForeignKey(
                        name: "FK_Competentie_Persoon_PersoonId",
                        column: x => x.PersoonId,
                        principalTable: "Persoon",
                        principalColumn: "PersoonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gilde",
                columns: table => new
                {
                    GildeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(nullable: true),
                    LeadPersoonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gilde", x => x.GildeId);
                    table.ForeignKey(
                        name: "FK_Gilde_Persoon_LeadPersoonId",
                        column: x => x.LeadPersoonId,
                        principalTable: "Persoon",
                        principalColumn: "PersoonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScrumTeam",
                columns: table => new
                {
                    ScrumTeamId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(nullable: true),
                    ScrummasterPersoonId = table.Column<int>(nullable: true),
                    ProductownerPersoonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScrumTeam", x => x.ScrumTeamId);
                    table.ForeignKey(
                        name: "FK_ScrumTeam_Persoon_ProductownerPersoonId",
                        column: x => x.ProductownerPersoonId,
                        principalTable: "Persoon",
                        principalColumn: "PersoonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScrumTeam_Persoon_ScrummasterPersoonId",
                        column: x => x.ScrummasterPersoonId,
                        principalTable: "Persoon",
                        principalColumn: "PersoonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(nullable: true),
                    ManagerPersoonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Team_Persoon_ManagerPersoonId",
                        column: x => x.ManagerPersoonId,
                        principalTable: "Persoon",
                        principalColumn: "PersoonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersoonGilde",
                columns: table => new
                {
                    PersoonId = table.Column<int>(nullable: false),
                    GildeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoonGilde", x => new { x.PersoonId, x.GildeId });
                    table.ForeignKey(
                        name: "FK_PersoonGilde_Gilde_GildeId",
                        column: x => x.GildeId,
                        principalTable: "Gilde",
                        principalColumn: "GildeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersoonGilde_Persoon_PersoonId",
                        column: x => x.PersoonId,
                        principalTable: "Persoon",
                        principalColumn: "PersoonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applicatie",
                columns: table => new
                {
                    ApplicatieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(nullable: true),
                    Technologie = table.Column<string>(nullable: true),
                    Versie = table.Column<string>(nullable: true),
                    ScrumTeamId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicatie", x => x.ApplicatieId);
                    table.ForeignKey(
                        name: "FK_Applicatie_ScrumTeam_ScrumTeamId",
                        column: x => x.ScrumTeamId,
                        principalTable: "ScrumTeam",
                        principalColumn: "ScrumTeamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersoonScrumTeam",
                columns: table => new
                {
                    PersoonId = table.Column<int>(nullable: false),
                    ScrumTeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoonScrumTeam", x => new { x.PersoonId, x.ScrumTeamId });
                    table.ForeignKey(
                        name: "FK_PersoonScrumTeam_Persoon_PersoonId",
                        column: x => x.PersoonId,
                        principalTable: "Persoon",
                        principalColumn: "PersoonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersoonScrumTeam_ScrumTeam_ScrumTeamId",
                        column: x => x.ScrumTeamId,
                        principalTable: "ScrumTeam",
                        principalColumn: "ScrumTeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersoonTeam",
                columns: table => new
                {
                    PersoonId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoonTeam", x => new { x.PersoonId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_PersoonTeam_Persoon_PersoonId",
                        column: x => x.PersoonId,
                        principalTable: "Persoon",
                        principalColumn: "PersoonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersoonTeam_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applicatie_ScrumTeamId",
                table: "Applicatie",
                column: "ScrumTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Competentie_PersoonId",
                table: "Competentie",
                column: "PersoonId");

            migrationBuilder.CreateIndex(
                name: "IX_Gilde_LeadPersoonId",
                table: "Gilde",
                column: "LeadPersoonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonGilde_GildeId",
                table: "PersoonGilde",
                column: "GildeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonScrumTeam_ScrumTeamId",
                table: "PersoonScrumTeam",
                column: "ScrumTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonTeam_TeamId",
                table: "PersoonTeam",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ScrumTeam_ProductownerPersoonId",
                table: "ScrumTeam",
                column: "ProductownerPersoonId");

            migrationBuilder.CreateIndex(
                name: "IX_ScrumTeam_ScrummasterPersoonId",
                table: "ScrumTeam",
                column: "ScrummasterPersoonId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_ManagerPersoonId",
                table: "Team",
                column: "ManagerPersoonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicatie");

            migrationBuilder.DropTable(
                name: "Competentie");

            migrationBuilder.DropTable(
                name: "PersoonGilde");

            migrationBuilder.DropTable(
                name: "PersoonScrumTeam");

            migrationBuilder.DropTable(
                name: "PersoonTeam");

            migrationBuilder.DropTable(
                name: "Gilde");

            migrationBuilder.DropTable(
                name: "ScrumTeam");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Persoon");
        }
    }
}
