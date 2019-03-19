using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstWebApp.Migrations
{
    public partial class GroupSearch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Audithory",
                table: "Group",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherName",
                table: "Group",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Group",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Audithory",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "TeacherName",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Group");
        }
    }
}
