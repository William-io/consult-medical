using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Consult.Domain.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consulting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Done = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulting", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consulting_User",
                table: "Consulting",
                column: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consulting");
        }
    }
}
