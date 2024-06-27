using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniCatalog.Data.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlanId",
                table: "Discipline",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Discipline",
                keyColumn: "Cod",
                keyValue: "15ab1",
                column: "PlanId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Discipline",
                keyColumn: "Cod",
                keyValue: "15ab2",
                column: "PlanId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Discipline",
                keyColumn: "Cod",
                keyValue: "15ab3",
                column: "PlanId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Discipline",
                keyColumn: "Cod",
                keyValue: "15ab4",
                column: "PlanId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Discipline",
                keyColumn: "Cod",
                keyValue: "15ab5",
                column: "PlanId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Discipline",
                keyColumn: "Cod",
                keyValue: "15ab6",
                column: "PlanId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Discipline",
                keyColumn: "Cod",
                keyValue: "15ab7",
                column: "PlanId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10917/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9105), 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10918/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9170), 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10919/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9173), 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10920/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9176), 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10921/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9179), 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10922/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9182), 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10923/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9185), 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10924/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9187), 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10925/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9190), 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10926/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9193), 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10927/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9196), 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10928/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9198), 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10929/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9201), 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "NrMatricol",
                keyValue: "10930/4lf422019",
                columns: new[] { "DataInscrierii", "PlanId" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 38, 40, 69, DateTimeKind.Local).AddTicks(9204), 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlanId",
                table: "Discipline");

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
    }
}
