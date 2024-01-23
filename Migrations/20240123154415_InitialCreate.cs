using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prepod",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Фамилия = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Имя = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Отчество = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Куратор_Группы = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Профессия = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    День_Рождения = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Номер_Кабинета = table.Column<int>(type: "int", nullable: false),
                    Зарплата = table.Column<int>(type: "int", nullable: false),
                    Стаж = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prepod", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Фамилия = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Имя = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Отчество = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Рост = table.Column<int>(type: "int", nullable: false),
                    День_Рождения = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Группа = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Специальность = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Стипендия = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Возраст = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prepod");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
