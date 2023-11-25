using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.Migrations
{
    /// <inheritdoc />
    public partial class UsuarionMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 11, 22, 18, 52, 0, 180, DateTimeKind.Local).AddTicks(1118), new DateTime(2023, 11, 22, 18, 52, 0, 180, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 11, 22, 18, 52, 0, 180, DateTimeKind.Local).AddTicks(1123), new DateTime(2023, 11, 22, 18, 52, 0, 180, DateTimeKind.Local).AddTicks(1122) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
