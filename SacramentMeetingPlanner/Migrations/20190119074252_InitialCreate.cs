using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Meeting",
                newName: "Subject3");

            migrationBuilder.RenameColumn(
                name: "Speaker",
                table: "Meeting",
                newName: "Subject2");

            migrationBuilder.AddColumn<string>(
                name: "Speaker1",
                table: "Meeting",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Speaker2",
                table: "Meeting",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Speaker3",
                table: "Meeting",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject1",
                table: "Meeting",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speaker1",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker2",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Speaker3",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Subject1",
                table: "Meeting");

            migrationBuilder.RenameColumn(
                name: "Subject3",
                table: "Meeting",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "Subject2",
                table: "Meeting",
                newName: "Speaker");
        }
    }
}
