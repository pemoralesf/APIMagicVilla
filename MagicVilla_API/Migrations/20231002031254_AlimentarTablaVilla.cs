﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TbVillas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa", new DateTime(2023, 10, 1, 21, 12, 54, 633, DateTimeKind.Local).AddTicks(6920), new DateTime(2023, 10, 1, 21, 12, 54, 633, DateTimeKind.Local).AddTicks(6900), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la Villa", new DateTime(2023, 10, 1, 21, 12, 54, 633, DateTimeKind.Local).AddTicks(6926), new DateTime(2023, 10, 1, 21, 12, 54, 633, DateTimeKind.Local).AddTicks(6925), "", 40, "Premiun Villa Real", 4, 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TbVillas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TbVillas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
