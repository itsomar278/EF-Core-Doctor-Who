using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class view : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW [viewEpisodes] AS 
                                   SELECT A.AuthorName AS AuthorName , 
                                          D.DoctorName AS DoctorName , 
	                                           dbo.fnCompanions(E.EpisodeId) AS Companions , 
	                                           dbo.fnEnemies(E.EpisodeId) AS Enemies 
	                                           FROM Episodes E 
	                                           INNER JOIN Doctors D 
	                                           ON D.DoctorId = E.DoctorID
	                                           INNER JOIN Authors A 
	                                           ON E.AuthorId = A.AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.Sql("DROP VIEW[viewEpisodes];");
        }
    }
}
