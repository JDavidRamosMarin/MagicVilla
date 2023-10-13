using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.Migrations
{
    public partial class AlimentarTablaVilla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetroCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[] { 1, "", "Detalle de la Villa", new DateTime(2023, 6, 1, 18, 33, 59, 254, DateTimeKind.Local).AddTicks(1190), new DateTime(2023, 6, 1, 18, 33, 59, 254, DateTimeKind.Local).AddTicks(1173), "", 50.0, "Villa Real", 5, 500.0 });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetroCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[] { 2, "", "Detalle de la Villa", new DateTime(2023, 6, 1, 18, 33, 59, 254, DateTimeKind.Local).AddTicks(1196), new DateTime(2023, 6, 1, 18, 33, 59, 254, DateTimeKind.Local).AddTicks(1195), "", 40.0, "Premium Vista a la Piscina", 4, 150.0 });
        }

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
