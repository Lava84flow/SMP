using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentMeetingPlanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bishopric = table.Column<string>(nullable: false),
                    OpeningPrayer = table.Column<string>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    MeetingDate = table.Column<DateTime>(nullable: false),
                    OpeningSong = table.Column<string>(nullable: false),
                    SacramentSong = table.Column<string>(nullable: false),
                    IntermediateSong = table.Column<string>(nullable: true),
                    ClosingSong = table.Column<string>(nullable: false),
                    ClosingPrayer = table.Column<string>(nullable: false),
                    Speaker = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
