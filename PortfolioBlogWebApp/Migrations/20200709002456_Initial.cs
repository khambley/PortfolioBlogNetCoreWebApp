using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioBlogWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTitle = table.Column<string>(nullable: true),
                    ProjectShortDesc = table.Column<string>(nullable: true),
                    ProjectLongDesc = table.Column<string>(nullable: true),
                    ProjectDateCreated = table.Column<DateTime>(nullable: false),
                    ProjectDateCompleted = table.Column<DateTime>(nullable: false),
                    ProjectType = table.Column<string>(nullable: true),
                    ProjectCategory = table.Column<string>(nullable: true),
                    ProjectImageFileName = table.Column<string>(nullable: true),
                    ProjectLogoFileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
