using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniCatalog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Grupe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Prenume",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<string>(
                name: "GrupaName",
                table: "Student",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Grupa",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupa", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "Grupa",
                column: "Name",
                value: "4lf421");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10917/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(1972), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10918/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2044), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10919/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2047), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10920/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2049), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10921/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2052), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10922/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2056), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10923/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2058), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10924/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2061), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10925/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2063), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10926/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2068), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10927/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2070), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10928/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2073), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10929/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2075), null });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10930/4lf422019",
                columns: new[] { "DataInscrierii", "GrupaName" },
                values: new object[] { new DateTime(2024, 6, 27, 3, 22, 8, 44, DateTimeKind.Local).AddTicks(2077), null });

            migrationBuilder.CreateIndex(
                name: "IX_Student_GrupaName",
                table: "Student",
                column: "GrupaName");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Grupa_GrupaName",
                table: "Student",
                column: "GrupaName",
                principalTable: "Grupa",
                principalColumn: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Grupa_GrupaName",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Grupa");

            migrationBuilder.DropIndex(
                name: "IX_Student_GrupaName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "GrupaName",
                table: "Student");

            migrationBuilder.AlterColumn<string>(
                name: "Prenume",
                table: "Student",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Student",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10917/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10918/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10919/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10920/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10921/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10922/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10923/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10924/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10925/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10926/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10927/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10928/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10929/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10930/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 26, 16, 49, 9, 498, DateTimeKind.Local).AddTicks(2703));
        }
    }
}
