using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Berkshire.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BerkshireReasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Reason = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Updated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BerkshireReasons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BerkshireReasons",
                columns: new[] { "Id", "Created", "Reason", "Updated" },
                values: new object[] { 1, new DateTime(2021, 8, 5, 18, 41, 6, 412, DateTimeKind.Utc).AddTicks(6170), "test 1", new DateTime(2021, 8, 5, 18, 41, 6, 412, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.InsertData(
                table: "BerkshireReasons",
                columns: new[] { "Id", "Created", "Reason", "Updated" },
                values: new object[] { 2, new DateTime(2021, 8, 5, 18, 41, 6, 412, DateTimeKind.Utc).AddTicks(6825), "test 1", new DateTime(2021, 8, 5, 18, 41, 6, 412, DateTimeKind.Utc).AddTicks(6827) });

            migrationBuilder.InsertData(
                table: "BerkshireReasons",
                columns: new[] { "Id", "Created", "Reason", "Updated" },
                values: new object[] { 3, new DateTime(2021, 8, 5, 18, 41, 6, 412, DateTimeKind.Utc).AddTicks(6829), "test 1", new DateTime(2021, 8, 5, 18, 41, 6, 412, DateTimeKind.Utc).AddTicks(6830) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BerkshireReasons");
        }
    }
}
