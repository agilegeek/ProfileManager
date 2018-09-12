using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfileManager.Migrations
{
    public partial class renameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicatie_ScrumTeam_ScrumTeamId",
                table: "Applicatie");

            migrationBuilder.DropForeignKey(
                name: "FK_Competentie_Persoon_PersoonId",
                table: "Competentie");

            migrationBuilder.DropForeignKey(
                name: "FK_Gilde_Persoon_LeadPersoonId",
                table: "Gilde");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonGilde_Gilde_GildeId",
                table: "PersoonGilde");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonGilde_Persoon_PersoonId",
                table: "PersoonGilde");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonScrumTeam_Persoon_PersoonId",
                table: "PersoonScrumTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonScrumTeam_ScrumTeam_ScrumTeamId",
                table: "PersoonScrumTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonTeam_Persoon_PersoonId",
                table: "PersoonTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonTeam_Team_TeamId",
                table: "PersoonTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_ScrumTeam_Persoon_ProductownerPersoonId",
                table: "ScrumTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_ScrumTeam_Persoon_ScrummasterPersoonId",
                table: "ScrumTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Persoon_ManagerPersoonId",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScrumTeam",
                table: "ScrumTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persoon",
                table: "Persoon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gilde",
                table: "Gilde");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Competentie",
                table: "Competentie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applicatie",
                table: "Applicatie");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "Teams");

            migrationBuilder.RenameTable(
                name: "ScrumTeam",
                newName: "ScrumTeams");

            migrationBuilder.RenameTable(
                name: "Persoon",
                newName: "Personen");

            migrationBuilder.RenameTable(
                name: "Gilde",
                newName: "Gildes");

            migrationBuilder.RenameTable(
                name: "Competentie",
                newName: "Competenties");

            migrationBuilder.RenameTable(
                name: "Applicatie",
                newName: "Applicaties");

            migrationBuilder.RenameIndex(
                name: "IX_Team_ManagerPersoonId",
                table: "Teams",
                newName: "IX_Teams_ManagerPersoonId");

            migrationBuilder.RenameIndex(
                name: "IX_ScrumTeam_ScrummasterPersoonId",
                table: "ScrumTeams",
                newName: "IX_ScrumTeams_ScrummasterPersoonId");

            migrationBuilder.RenameIndex(
                name: "IX_ScrumTeam_ProductownerPersoonId",
                table: "ScrumTeams",
                newName: "IX_ScrumTeams_ProductownerPersoonId");

            migrationBuilder.RenameIndex(
                name: "IX_Gilde_LeadPersoonId",
                table: "Gildes",
                newName: "IX_Gildes_LeadPersoonId");

            migrationBuilder.RenameIndex(
                name: "IX_Competentie_PersoonId",
                table: "Competenties",
                newName: "IX_Competenties_PersoonId");

            migrationBuilder.RenameIndex(
                name: "IX_Applicatie_ScrumTeamId",
                table: "Applicaties",
                newName: "IX_Applicaties_ScrumTeamId");

            migrationBuilder.AddColumn<string>(
                name: "Beschrijving",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Beschrijving",
                table: "ScrumTeams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocatieId",
                table: "ScrumTeams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocatieId",
                table: "Personen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelefoonNummer",
                table: "Personen",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScrumTeams",
                table: "ScrumTeams",
                column: "ScrumTeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personen",
                table: "Personen",
                column: "PersoonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gildes",
                table: "Gildes",
                column: "GildeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Competenties",
                table: "Competenties",
                column: "CompetentieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applicaties",
                table: "Applicaties",
                column: "ApplicatieId");

            migrationBuilder.CreateTable(
                name: "Locaties",
                columns: table => new
                {
                    LocatieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vestiging = table.Column<string>(nullable: true),
                    Kantoor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locaties", x => x.LocatieId);
                });

            migrationBuilder.CreateTable(
                name: "Rollen",
                columns: table => new
                {
                    RolId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(nullable: true),
                    Beschrijving = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rollen", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "PersoonRol",
                columns: table => new
                {
                    PersoonId = table.Column<int>(nullable: false),
                    RolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersoonRol", x => new { x.PersoonId, x.RolId });
                    table.ForeignKey(
                        name: "FK_PersoonRol_Personen_PersoonId",
                        column: x => x.PersoonId,
                        principalTable: "Personen",
                        principalColumn: "PersoonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersoonRol_Rollen_RolId",
                        column: x => x.RolId,
                        principalTable: "Rollen",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScrumTeams_LocatieId",
                table: "ScrumTeams",
                column: "LocatieId");

            migrationBuilder.CreateIndex(
                name: "IX_Personen_LocatieId",
                table: "Personen",
                column: "LocatieId");

            migrationBuilder.CreateIndex(
                name: "IX_PersoonRol_RolId",
                table: "PersoonRol",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicaties_ScrumTeams_ScrumTeamId",
                table: "Applicaties",
                column: "ScrumTeamId",
                principalTable: "ScrumTeams",
                principalColumn: "ScrumTeamId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Competenties_Personen_PersoonId",
                table: "Competenties",
                column: "PersoonId",
                principalTable: "Personen",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gildes_Personen_LeadPersoonId",
                table: "Gildes",
                column: "LeadPersoonId",
                principalTable: "Personen",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personen_Locaties_LocatieId",
                table: "Personen",
                column: "LocatieId",
                principalTable: "Locaties",
                principalColumn: "LocatieId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonGilde_Gildes_GildeId",
                table: "PersoonGilde",
                column: "GildeId",
                principalTable: "Gildes",
                principalColumn: "GildeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonGilde_Personen_PersoonId",
                table: "PersoonGilde",
                column: "PersoonId",
                principalTable: "Personen",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonScrumTeam_Personen_PersoonId",
                table: "PersoonScrumTeam",
                column: "PersoonId",
                principalTable: "Personen",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonScrumTeam_ScrumTeams_ScrumTeamId",
                table: "PersoonScrumTeam",
                column: "ScrumTeamId",
                principalTable: "ScrumTeams",
                principalColumn: "ScrumTeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonTeam_Personen_PersoonId",
                table: "PersoonTeam",
                column: "PersoonId",
                principalTable: "Personen",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonTeam_Teams_TeamId",
                table: "PersoonTeam",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScrumTeams_Locaties_LocatieId",
                table: "ScrumTeams",
                column: "LocatieId",
                principalTable: "Locaties",
                principalColumn: "LocatieId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScrumTeams_Personen_ProductownerPersoonId",
                table: "ScrumTeams",
                column: "ProductownerPersoonId",
                principalTable: "Personen",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScrumTeams_Personen_ScrummasterPersoonId",
                table: "ScrumTeams",
                column: "ScrummasterPersoonId",
                principalTable: "Personen",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Personen_ManagerPersoonId",
                table: "Teams",
                column: "ManagerPersoonId",
                principalTable: "Personen",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicaties_ScrumTeams_ScrumTeamId",
                table: "Applicaties");

            migrationBuilder.DropForeignKey(
                name: "FK_Competenties_Personen_PersoonId",
                table: "Competenties");

            migrationBuilder.DropForeignKey(
                name: "FK_Gildes_Personen_LeadPersoonId",
                table: "Gildes");

            migrationBuilder.DropForeignKey(
                name: "FK_Personen_Locaties_LocatieId",
                table: "Personen");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonGilde_Gildes_GildeId",
                table: "PersoonGilde");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonGilde_Personen_PersoonId",
                table: "PersoonGilde");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonScrumTeam_Personen_PersoonId",
                table: "PersoonScrumTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonScrumTeam_ScrumTeams_ScrumTeamId",
                table: "PersoonScrumTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonTeam_Personen_PersoonId",
                table: "PersoonTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PersoonTeam_Teams_TeamId",
                table: "PersoonTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_ScrumTeams_Locaties_LocatieId",
                table: "ScrumTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_ScrumTeams_Personen_ProductownerPersoonId",
                table: "ScrumTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_ScrumTeams_Personen_ScrummasterPersoonId",
                table: "ScrumTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Personen_ManagerPersoonId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "Locaties");

            migrationBuilder.DropTable(
                name: "PersoonRol");

            migrationBuilder.DropTable(
                name: "Rollen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScrumTeams",
                table: "ScrumTeams");

            migrationBuilder.DropIndex(
                name: "IX_ScrumTeams_LocatieId",
                table: "ScrumTeams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personen",
                table: "Personen");

            migrationBuilder.DropIndex(
                name: "IX_Personen_LocatieId",
                table: "Personen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gildes",
                table: "Gildes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Competenties",
                table: "Competenties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applicaties",
                table: "Applicaties");

            migrationBuilder.DropColumn(
                name: "Beschrijving",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Beschrijving",
                table: "ScrumTeams");

            migrationBuilder.DropColumn(
                name: "LocatieId",
                table: "ScrumTeams");

            migrationBuilder.DropColumn(
                name: "LocatieId",
                table: "Personen");

            migrationBuilder.DropColumn(
                name: "TelefoonNummer",
                table: "Personen");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "Team");

            migrationBuilder.RenameTable(
                name: "ScrumTeams",
                newName: "ScrumTeam");

            migrationBuilder.RenameTable(
                name: "Personen",
                newName: "Persoon");

            migrationBuilder.RenameTable(
                name: "Gildes",
                newName: "Gilde");

            migrationBuilder.RenameTable(
                name: "Competenties",
                newName: "Competentie");

            migrationBuilder.RenameTable(
                name: "Applicaties",
                newName: "Applicatie");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_ManagerPersoonId",
                table: "Team",
                newName: "IX_Team_ManagerPersoonId");

            migrationBuilder.RenameIndex(
                name: "IX_ScrumTeams_ScrummasterPersoonId",
                table: "ScrumTeam",
                newName: "IX_ScrumTeam_ScrummasterPersoonId");

            migrationBuilder.RenameIndex(
                name: "IX_ScrumTeams_ProductownerPersoonId",
                table: "ScrumTeam",
                newName: "IX_ScrumTeam_ProductownerPersoonId");

            migrationBuilder.RenameIndex(
                name: "IX_Gildes_LeadPersoonId",
                table: "Gilde",
                newName: "IX_Gilde_LeadPersoonId");

            migrationBuilder.RenameIndex(
                name: "IX_Competenties_PersoonId",
                table: "Competentie",
                newName: "IX_Competentie_PersoonId");

            migrationBuilder.RenameIndex(
                name: "IX_Applicaties_ScrumTeamId",
                table: "Applicatie",
                newName: "IX_Applicatie_ScrumTeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScrumTeam",
                table: "ScrumTeam",
                column: "ScrumTeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persoon",
                table: "Persoon",
                column: "PersoonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gilde",
                table: "Gilde",
                column: "GildeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Competentie",
                table: "Competentie",
                column: "CompetentieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applicatie",
                table: "Applicatie",
                column: "ApplicatieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicatie_ScrumTeam_ScrumTeamId",
                table: "Applicatie",
                column: "ScrumTeamId",
                principalTable: "ScrumTeam",
                principalColumn: "ScrumTeamId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Competentie_Persoon_PersoonId",
                table: "Competentie",
                column: "PersoonId",
                principalTable: "Persoon",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gilde_Persoon_LeadPersoonId",
                table: "Gilde",
                column: "LeadPersoonId",
                principalTable: "Persoon",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonGilde_Gilde_GildeId",
                table: "PersoonGilde",
                column: "GildeId",
                principalTable: "Gilde",
                principalColumn: "GildeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonGilde_Persoon_PersoonId",
                table: "PersoonGilde",
                column: "PersoonId",
                principalTable: "Persoon",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonScrumTeam_Persoon_PersoonId",
                table: "PersoonScrumTeam",
                column: "PersoonId",
                principalTable: "Persoon",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonScrumTeam_ScrumTeam_ScrumTeamId",
                table: "PersoonScrumTeam",
                column: "ScrumTeamId",
                principalTable: "ScrumTeam",
                principalColumn: "ScrumTeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonTeam_Persoon_PersoonId",
                table: "PersoonTeam",
                column: "PersoonId",
                principalTable: "Persoon",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersoonTeam_Team_TeamId",
                table: "PersoonTeam",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScrumTeam_Persoon_ProductownerPersoonId",
                table: "ScrumTeam",
                column: "ProductownerPersoonId",
                principalTable: "Persoon",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScrumTeam_Persoon_ScrummasterPersoonId",
                table: "ScrumTeam",
                column: "ScrummasterPersoonId",
                principalTable: "Persoon",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Persoon_ManagerPersoonId",
                table: "Team",
                column: "ManagerPersoonId",
                principalTable: "Persoon",
                principalColumn: "PersoonId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
