using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstWebApp.Migrations
{
    public partial class StudentDBChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Subjects");

            //migrationBuilder.DropColumn(
            //    name: "ReleaseDate",
            //    table: "Student");

            migrationBuilder.RenameColumn(
                name: "SurnameOfTeacher",
                table: "Subjects",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "NameOfTeacher",
                table: "Subjects",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Student",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Student",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Audithory",
                table: "Subjects",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Student",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Student",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Student",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordConfirm",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Student",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "PasswordConfirm",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Subjects",
                newName: "SurnameOfTeacher");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Subjects",
                newName: "NameOfTeacher");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Student",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Student",
                newName: "Genre");

            migrationBuilder.AlterColumn<int>(
                name: "Audithory",
                table: "Subjects",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Subjects",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Age",
                table: "Student",
                nullable: false,
                oldClrType: typeof(int));

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "ReleaseDate",
            //    table: "Student",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
