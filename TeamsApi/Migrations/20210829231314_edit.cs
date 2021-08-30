using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamsApi.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nationaity",
                table: "players",
                newName: "Nationality");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nationality",
                table: "players",
                newName: "Nationaity");
        }
    }
}
