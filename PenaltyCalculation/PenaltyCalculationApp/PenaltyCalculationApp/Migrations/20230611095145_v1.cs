using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PenaltyCalculationApp.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holidays_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Currency", "Name" },
                values: new object[] { 1, "TR", "Turkey" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Currency", "Name" },
                values: new object[] { 2, "AE", "United Arab Emirates" });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "CountryId", "Date", "Name" },
                values: new object[] { 1, 2, new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eid" });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "CountryId", "Date", "Name" },
                values: new object[] { 2, 2, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eid" });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "CountryId", "Date", "Name" },
                values: new object[] { 4, 1, new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "29 Ekim Cumhuriyet Bayrami" });

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_CountryId",
                table: "Holidays",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
