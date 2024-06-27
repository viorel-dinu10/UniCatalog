using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniCatalog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Discipline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlanId",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Discipline",
                columns: table => new
                {
                    Cod = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acronim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Credite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discipline", x => x.Cod);
                });

            migrationBuilder.InsertData(
                table: "Discipline",
                columns: new[] { "Cod", "Acronim", "Credite", "Name" },
                values: new object[,]
                {
                    { "15ab1", "TS", 4, "Teoria Sistemelor" },
                    { "15ab2", "F", 5, "Fizica" },
                    { "15ab3", "MS", 6, "Matematici Speciale" },
                    { "15ab4", "E", 3, "Electrotehnica" },
                    { "15ab5", "ALGAD", 6, "Algebra Liniara" },
                    { "15ab6", "PCLP", 5, "Programarea Calclatoarelor" },
                    { "15ab7", "POO", 4, "Programare orientata pe obiect" }
                });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10917/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9587), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10918/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9655), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10919/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9658), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10920/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9660), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10921/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9663), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10922/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9666), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10923/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9669), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10924/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9671), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10925/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9674), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10926/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9677), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10927/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9680), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10928/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9683), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10929/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9685), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10930/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 34, 34, 338, DateTimeKind.Local).AddTicks(9688), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discipline");

            migrationBuilder.DropColumn(
                name: "PlanId",
                table: "Student");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10917/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10918/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10919/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10920/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10921/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10922/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10923/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10924/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10925/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10926/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10927/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10928/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10929/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10930/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 10, 10, 953, DateTimeKind.Local).AddTicks(1411));
        }
    }
}
