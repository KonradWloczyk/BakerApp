using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BakerApp.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Client");

            migrationBuilder.AddColumn<int>(
                name: "Contact",
                table: "Client",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Client",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Client",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Client");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Client",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
