using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class StoredProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE spSummariseEpisodes   
                                       @HighestEnemies VARCHAR(MAX) OUTPUT,
                                       @HighestCompanions VARCHAR(MAX) OUTPUT
                                    AS
                                    BEGIN
                                    Select TOP 3 @HighestEnemies = CONCAT(E.EnemyName, '   ,   ', @HighestEnemies)
                                    FROM EnemyEpisodes EE
                                    INNER JOIN Enemies E
                                    ON E.EnemyId = EE.EnemyId
                                    GROUP BY E.EnemyName
                                    Order BY COUNT(EE.EnemyId) DESC
                                    Select TOP 3 @HighestCompanions = CONCAT(C.CompanionName, '   ,   ', @HighestCompanions)
                                    FROM Companions C
                                    INNER JOIN CompanionsEpisodes EC
                                    ON C.CompanionId = EC.CompanionId
                                    GROUP BY C.CompanionName
                                    Order BY COUNT(EC.CompanionId) DESC
                                    END;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE dbo.spSummariseEpisodes;");
        }
    }
}
