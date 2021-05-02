using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddedOgretmen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Siniflar",
                keyColumn: "Id",
                keyValue: 1,
                column: "SinifDuzeyi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Siniflar",
                keyColumn: "Id",
                keyValue: 2,
                column: "SinifDuzeyi",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Siniflar",
                keyColumn: "Id",
                keyValue: 1,
                column: "SinifDuzeyi",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Siniflar",
                keyColumn: "Id",
                keyValue: 2,
                column: "SinifDuzeyi",
                value: 0);
        }
    }
}
