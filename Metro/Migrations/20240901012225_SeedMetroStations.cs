using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Metro.Migrations
{
    /// <inheritdoc />
    public partial class SeedMetroStations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Line1Stations",
                columns: new[] { "Id", "StationName" },
                values: new object[,]
                {
                    { 1, "Helwan" },
                    { 2, "Ain Helwan" },
                    { 3, "Helwan University" },
                    { 4, "Wadi Hof" },
                    { 5, "Hadayek Helwan" },
                    { 6, "El Maasara" },
                    { 7, "Tora El Asmant" },
                    { 8, "Kozzika" },
                    { 9, "Tora El Balad" },
                    { 10, "Sakanat El Maadi" },
                    { 11, "Maadi" },
                    { 12, "Hadayek El Maadi" },
                    { 13, "Dar El Salam" },
                    { 14, "El Zahraa" },
                    { 15, "Mar Girgis" },
                    { 16, "El Malek El Saleh" },
                    { 17, "Al Sayeda Zeinab" },
                    { 18, "Saad Zaghloul" },
                    { 19, "Sadat" },
                    { 20, "Nasser" },
                    { 21, "Orabi" },
                    { 22, "Al Shohadaa" },
                    { 23, "Ghamra" },
                    { 24, "El Demerdash" },
                    { 25, "Manshiet El Sadr" },
                    { 26, "Kobri El Qobba" },
                    { 27, "Hammamat El Qobba" },
                    { 28, "Saray El Qobba" },
                    { 29, "Hadayeq El Zaitoun" },
                    { 30, "Helmeyet El Zaitoun" },
                    { 31, "El Matareyya" },
                    { 32, "Ain Shams" },
                    { 33, "Ezbet El Nakhl" },
                    { 34, "El Marg" },
                    { 35, "New El Marg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Line1Stations",
                keyColumn: "Id",
                keyValue: 35);
        }
    }
}
