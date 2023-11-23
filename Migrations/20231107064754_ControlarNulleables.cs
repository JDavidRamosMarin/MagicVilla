using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.Migrations
{
    /// <inheritdoc />
    public partial class ControlarNulleables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 47, 53, 690, DateTimeKind.Local).AddTicks(9238), new DateTime(2023, 11, 7, 0, 47, 53, 690, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 11, 7, 0, 47, 53, 690, DateTimeKind.Local).AddTicks(9245), new DateTime(2023, 11, 7, 0, 47, 53, 690, DateTimeKind.Local).AddTicks(9244) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 24, 3, 786, DateTimeKind.Local).AddTicks(7608), new DateTime(2023, 10, 20, 0, 24, 3, 786, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 24, 3, 786, DateTimeKind.Local).AddTicks(7614), new DateTime(2023, 10, 20, 0, 24, 3, 786, DateTimeKind.Local).AddTicks(7612) });
        }
    }
}
