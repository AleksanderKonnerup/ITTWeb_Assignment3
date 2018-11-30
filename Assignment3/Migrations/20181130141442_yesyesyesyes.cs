using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class yesyesyesyes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentType_Image_ImageESImageId",
                table: "ComponentType");

            migrationBuilder.DropIndex(
                name: "IX_ComponentType_ImageESImageId",
                table: "ComponentType");

            migrationBuilder.DropColumn(
                name: "ImageESImageId",
                table: "ComponentType");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "ComponentType",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "ComponentType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageMimeType",
                table: "ComponentType",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "ComponentType");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "ComponentType");

            migrationBuilder.DropColumn(
                name: "ImageMimeType",
                table: "ComponentType");

            migrationBuilder.AddColumn<long>(
                name: "ImageESImageId",
                table: "ComponentType",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComponentType_ImageESImageId",
                table: "ComponentType",
                column: "ImageESImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentType_Image_ImageESImageId",
                table: "ComponentType",
                column: "ImageESImageId",
                principalTable: "Image",
                principalColumn: "ESImageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
