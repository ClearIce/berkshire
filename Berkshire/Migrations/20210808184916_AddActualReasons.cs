using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Berkshire.Migrations
{
    public partial class AddActualReasons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BerkshireReasons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "BerkshireReasons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Reason", "Updated" },
                values: new object[] { new DateTime(2021, 8, 8, 18, 49, 16, 270, DateTimeKind.Utc).AddTicks(7864), "Work with colleagues that have integrity, intelligence, and energy", new DateTime(2021, 8, 8, 18, 49, 16, 270, DateTimeKind.Utc).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "BerkshireReasons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Reason", "Updated" },
                values: new object[] { new DateTime(2021, 8, 8, 18, 49, 16, 270, DateTimeKind.Utc).AddTicks(8519), "Continue to be curious about technology and deliver valuable solutions", new DateTime(2021, 8, 8, 18, 49, 16, 270, DateTimeKind.Utc).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "BerkshireReasons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Reason", "Updated" },
                values: new object[] { new DateTime(2021, 8, 8, 18, 49, 16, 270, DateTimeKind.Utc).AddTicks(8523), "Contribute to the financial strength and security of BHHC's customers, partners, and employees", new DateTime(2021, 8, 8, 18, 49, 16, 270, DateTimeKind.Utc).AddTicks(8524) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BerkshireReasons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Reason", "Updated" },
                values: new object[] { new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(5672), "First reason", new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "BerkshireReasons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Reason", "Updated" },
                values: new object[] { new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6318), "Second reason", new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "BerkshireReasons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Reason", "Updated" },
                values: new object[] { new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6322), "Third reason", new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6323) });

            migrationBuilder.InsertData(
                table: "BerkshireReasons",
                columns: new[] { "Id", "Created", "Reason", "Updated" },
                values: new object[] { 4, new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6324), "Invalid Reason", new DateTime(2021, 8, 6, 12, 36, 52, 675, DateTimeKind.Utc).AddTicks(6325) });
        }
    }
}
