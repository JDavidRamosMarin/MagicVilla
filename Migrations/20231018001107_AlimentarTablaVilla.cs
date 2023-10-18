using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa...", new DateTime(2023, 10, 17, 18, 11, 7, 29, DateTimeKind.Local).AddTicks(6746), new DateTime(2023, 10, 17, 18, 11, 7, 29, DateTimeKind.Local).AddTicks(6727), "", 50, "Villa Real", 5, 200 },
                    { 2, "", "Detalle de la Villa...", new DateTime(2023, 10, 17, 18, 11, 7, 29, DateTimeKind.Local).AddTicks(6753), new DateTime(2023, 10, 17, 18, 11, 7, 29, DateTimeKind.Local).AddTicks(6751), "", 50, "Premium vista a la piscina", 4, 150 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
