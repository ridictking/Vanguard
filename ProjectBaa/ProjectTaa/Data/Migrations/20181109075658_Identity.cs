using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectTaa.Data.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CallerName = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    LogDate = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    LocalGovernment = table.Column<string>(nullable: false),
                    StreetName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    CallDescription = table.Column<string>(maxLength: 1024, nullable: false),
                    ImportanceLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Log");
        }
    }
}
