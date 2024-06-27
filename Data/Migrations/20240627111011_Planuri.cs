using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniCatalog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Planuri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grupa",
                keyColumn: "Name",
                keyValue: "4lf421");

            migrationBuilder.DropColumn(
                name: "CicluDeInvatamant",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "PlanDeInvatamantId",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PlanuriDeInvatamant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CicluDeInvatamant = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    An = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanuriDeInvatamant", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PlanuriDeInvatamant",
                columns: new[] { "Id", "An", "CicluDeInvatamant", "Name" },
                values: new object[,]
                {
                    { 1, 1, 0, "AIA" },
                    { 2, 2, 1, "AIA" }
                });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10917/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1326), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10918/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1386), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10919/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1388), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10920/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1390), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10921/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1392), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10922/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1394), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10923/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1396), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10924/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1399), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10925/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1401), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10926/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1403), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10927/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1405), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10928/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1407), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10929/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1409), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10930/4lf422019",
                columns: new[] { "DataInscrierii", "PlanDeInvatamantId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1411), null });

            migrationBuilder.CreateIndex(
                name: "IX_Student_PlanDeInvatamantId",
                table: "Student",
                column: "PlanDeInvatamantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_PlanuriDeInvatamant_PlanDeInvatamantId",
                table: "Student",
                column: "PlanDeInvatamantId",
                principalTable: "PlanuriDeInvatamant",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_PlanuriDeInvatamant_PlanDeInvatamantId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "PlanuriDeInvatamant");

            migrationBuilder.DropIndex(
                name: "IX_Student_PlanDeInvatamantId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "PlanDeInvatamantId",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "CicluDeInvatamant",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Grupa",
                column: "Name",
                value: "4lf421");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10917/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10918/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10919/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10920/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10921/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10922/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10923/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10924/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10925/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10926/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10927/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10928/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10929/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10930/4lf422019",
                columns: new[] { "CicluDeInvatamant", "DataInscrierii" },
                values: new object[] { 0, new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2077) });
        }
    }
}
