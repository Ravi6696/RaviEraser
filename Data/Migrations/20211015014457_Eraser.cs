using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RaviEraser.Data.Migrations
{
    public partial class Eraser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Eraser");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Eraser",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Eraser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Eraser",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Eraser");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Eraser");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Eraser",
                newName: "Genre");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Eraser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
