using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    president = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    conducting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    invocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sacramentHymnNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sacramentHymnName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    special = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    closingHymnNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    closingHymnName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    benediction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dismissalSongNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dismissalSongName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    planId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "Speaker");
        }
    }
}
