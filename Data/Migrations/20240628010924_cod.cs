using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniCatalog.Data.Migrations
{
    /// <inheritdoc />
    public partial class cod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PlanId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cod",
                table: "PlanuriDeInvatamant",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "PlanuriDeInvatamant",
                keyColumn: "Id",
                keyValue: 1,
                column: "Cod",
                value: "2");

            migrationBuilder.UpdateData(
                table: "PlanuriDeInvatamant",
                keyColumn: "Id",
                keyValue: 2,
                column: "Cod",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10917/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10918/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10919/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10920/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10921/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10922/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10923/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10924/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10925/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10926/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10927/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10928/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10929/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10930/4lf422019",
                column: "DataInscrierii",
                value: new DateTime(2024, 6, 28, 4, 9, 24, 817, DateTimeKind.Local).AddTicks(3415));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cod",
                table: "PlanuriDeInvatamant");

            migrationBuilder.AlterColumn<int>(
                name: "PlanId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
