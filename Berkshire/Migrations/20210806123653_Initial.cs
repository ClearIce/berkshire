using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Berkshire.Migrations
{
    public partial class Initial : Migration
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
                values: new object[] { 1, new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(5672), "First reason", new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.InsertData(
                table: "BerkshireReasons",
                columns: new[] { "Id", "Created", "Reason", "Updated" },
                values: new object[] { 2, new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6318), "Second reason", new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.InsertData(
                table: "BerkshireReasons",
                columns: new[] { "Id", "Created", "Reason", "Updated" },
                values: new object[] { 3, new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6322), "Third reason", new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6323) });

            migrationBuilder.InsertData(
                table: "BerkshireReasons",
                columns: new[] { "Id", "Created", "Reason", "Updated" },
                values: new object[] { 4, new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6324), "Invalid Reason", new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6325) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BerkshireReasons");
        }
    }
}
