using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Author1" },
                    { 2, "Author2" },
                    { 3, "Author3" },
                    { 4, "Author4" },
                    { 5, "Author5" }
                });

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPayed" },
                values: new object[,]
                {
                    { 1, "Companion1", "Payer1" },
                    { 2, "Companion1", "Payer2" },
                    { 3, "Companion1", "Payer3" },
                    { 4, "Companion1", "Payer4" },
                    { 5, "Companion1", "Payer5" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doctor1", 11, null, null },
                    { 2, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doctor2", 22, null, null },
                    { 3, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doctor3", 33, null, null },
                    { 4, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doctor4", 44, null, null },
                    { 5, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doctor5", 55, null, null }
                });

            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyId", "Describtion", "EnemyName" },
                values: new object[,]
                {
                    { 1, "o", "Enemy1" },
                    { 2, "o", "Enemy2" },
                    { 3, "o", "Enemy3" },
                    { 4, "o", "Enemy4" },
                    { 5, "o", "Enemy5" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "o", "oo", 1, "1" },
                    { 2, 2, 2, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "o", "oo", 2, "1" },
                    { 3, 3, 3, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "o", "oo", 3, "1" },
                    { 4, 4, 4, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "o", "oo", 4, "1" },
                    { 5, 5, 5, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "o", "oo", 5, "1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);
        }
    }
}
