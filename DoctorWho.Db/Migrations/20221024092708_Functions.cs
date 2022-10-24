using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class Functions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                   CREATE FUNCTION fnCompanions(@EpisodeId INT)
                                   RETURNS VARCHAR(MAX)
                                   AS
                                   BEGIN
                                   Declare @output AS VARCHAR(MAX)
                                        SELECT @output = CONCAT( 'Companion No ' ,
	                                                                 CAST(ROW_NUMBER() OVER(order by C.CompanionId) AS varchar ) 
							                                                                , ' : '
							                                                               , C.CompanionName 
							                                                               , ' , '
							                                                               , @output)
	                                        FROM tblCompanion C
	                                        INNER JOIN tblEpisodeCompanion AS EC
	                                        ON c.CompanionId = EC.CompanionId
	                                        WHERE @EpisodeId = EC.EpisodeId
                                   RETURN @Output; 
                                   END;
                                      ");
            migrationBuilder.Sql(@"
                                    CREATE FUNCTION fnEnemies (@EpisodeId INT)
                                    RETURNS VARCHAR(MAX)
                                    AS
                                    BEGIN
                                    Declare @output AS VARCHAR(MAX)
                                        SELECT @output = CONCAT( 'Enemy No ' ,
	                                                              CAST(ROW_NUMBER() OVER(order by E.EnemyId) AS varchar ) 
							                                      , ' : '
							                                     , E.EnemyName
							                                     , ' , '
							                                     , @output)
	                                     FROM tblEnemy E
	                                     INNER JOIN tblEpisodeEnemy AS EE
	                                     ON E.EnemyId = EE.EnemyId
	                                     WHERE @EpisodeId = EE.EpisodeId
                                    RETURN @Output; 
                                    END;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION fnCompanions ;");
            migrationBuilder.Sql("DROP FUNCTION fnEnemies ; ");

        }
    }
}
