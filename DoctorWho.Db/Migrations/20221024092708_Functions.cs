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
	                                        FROM Companions C
	                                        INNER JOIN CompanionsEpisodes AS EC
	                                        ON C.CompanionId = EC.CompanionId
	                                        WHERE @EpisodeId = EC.EpisodeId
                                   RETURN @Output; 
                                   END;
                                      "
            );
        }
           

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION fnCompanions ;");
        }
    }
}
