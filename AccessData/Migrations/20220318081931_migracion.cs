using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessData.Migrations
{
    public partial class migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "FuncionId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
