using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class testtt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanionEpisode");

            migrationBuilder.DropTable(
                name: "EnemyEpisode");

            migrationBuilder.CreateTable(
                name: "CompanionsEpisodes",
                columns: table => new
                {
                    CompanionId = table.Column<int>(type: "int", nullable: false),
                    EpisodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionsEpisodes", x => new { x.CompanionId, x.EpisodeId });
                    table.ForeignKey(
                        name: "FK_CompanionsEpisodes_Companions_CompanionId",
                        column: x => x.CompanionId,
                        principalTable: "Companions",
                        principalColumn: "CompanionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanionsEpisodes_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnemyEpisodes",
                columns: table => new
                {
                    EpisodeId = table.Column<int>(type: "int", nullable: false),
                    EnemyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnemyEpisodes", x => new { x.EnemyId, x.EpisodeId });
                    table.ForeignKey(
                        name: "FK_EnemyEpisodes_Enemies_EnemyId",
                        column: x => x.EnemyId,
                        principalTable: "Enemies",
                        principalColumn: "EnemyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnemyEpisodes_Episodes_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CompanionsEpisodes",
                columns: new[] { "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "EnemyEpisodes",
                columns: new[] { "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanionsEpisodes_EpisodeId",
                table: "CompanionsEpisodes",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_EnemyEpisodes_EpisodeId",
                table: "EnemyEpisodes",
                column: "EpisodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanionsEpisodes");

            migrationBuilder.DropTable(
                name: "EnemyEpisodes");

            migrationBuilder.CreateTable(
                name: "CompanionEpisode",
                columns: table => new
                {
                    CompanionsCompanionId = table.Column<int>(type: "int", nullable: false),
                    EpisodesEpisodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanionEpisode", x => new { x.CompanionsCompanionId, x.EpisodesEpisodeId });
                    table.ForeignKey(
                        name: "FK_CompanionEpisode_Companions_CompanionsCompanionId",
                        column: x => x.CompanionsCompanionId,
                        principalTable: "Companions",
                        principalColumn: "CompanionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanionEpisode_Episodes_EpisodesEpisodeId",
                        column: x => x.EpisodesEpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnemyEpisode",
                columns: table => new
                {
                    EnemiesEnemyId = table.Column<int>(type: "int", nullable: false),
                    EpisodesEpisodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnemyEpisode", x => new { x.EnemiesEnemyId, x.EpisodesEpisodeId });
                    table.ForeignKey(
                        name: "FK_EnemyEpisode_Enemies_EnemiesEnemyId",
                        column: x => x.EnemiesEnemyId,
                        principalTable: "Enemies",
                        principalColumn: "EnemyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnemyEpisode_Episodes_EpisodesEpisodeId",
                        column: x => x.EpisodesEpisodeId,
                        principalTable: "Episodes",
                        principalColumn: "EpisodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanionEpisode_EpisodesEpisodeId",
                table: "CompanionEpisode",
                column: "EpisodesEpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_EnemyEpisode_EpisodesEpisodeId",
                table: "EnemyEpisode",
                column: "EpisodesEpisodeId");
        }
    }
}
