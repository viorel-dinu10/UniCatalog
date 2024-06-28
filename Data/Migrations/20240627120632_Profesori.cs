using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniCatalog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Profesori : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadreDidactice",
                columns: table => new
                {
                    MarcaAngajat = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titlu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Post = table.Column<int>(type: "int", nullable: false),
                    DisciplinaId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadreDidactice", x => x.MarcaAngajat);
                });

            migrationBuilder.InsertData(
                table: "CadreDidactice",
                columns: new[] { "MarcaAngajat", "DisciplinaId", "Nume", "Post", "Prenume", "Titlu" },
                values: new object[,]
                {
                    { "13ef1", "15ab1", "Popescu", 0, "Ion", "Dr." },
                    { "13ef2", "15ab2", "Georgescu", 3, "Marius", "Dr. Ing." },
                    { "13ef3", "15ab3", "Ion", 3, "Elena", "Dr." },
                    { "13ef4", "15ab4", "Radu", 0, "Constantin", "Dr." },
                    { "13ef5", "15ab5", "Pop", 4, "Carmen", "Dr.Ing." },
                    { "13ef6", "15ab6", "Dan", 2, "Alexandra", "Dr." },
                    { "13ef7", "15ab7", "Ionescu", 3, "Maria", "Dr." }
                });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10917/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10918/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10919/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10920/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10921/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10922/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10923/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10924/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10925/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10926/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10927/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10928/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10929/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10930/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 15, 6, 31, 925, DateTimeKind.Local).AddTicks(3966));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadreDidactice");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10917/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10918/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10919/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10920/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10921/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10922/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10923/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10924/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10925/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10926/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10927/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10928/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10929/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10930/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9204));
        }
    }
}
