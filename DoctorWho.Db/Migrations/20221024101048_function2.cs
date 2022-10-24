using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class function2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
	                                     FROM Enemies E
	                                     INNER JOIN EnemyEpisodes AS EE
	                                     ON E.EnemyId = EE.EnemyId
	                                     WHERE @EpisodeId = EE.EpisodeId
                                    RETURN @Output; 
                                    END;"
);
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION fnEnemies ; ");
        }
    }
}

