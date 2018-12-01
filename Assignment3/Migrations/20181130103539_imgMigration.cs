using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class imgMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentType_ESImage_ImageESImageId",
                table: "ComponentType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ESImage",
                table: "ESImage");

            migrationBuilder.RenameTable(
                name: "ESImage",
                newName: "Image");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Image",
                table: "Image",
                column: "ESImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentType_Image_ImageESImageId",
                table: "ComponentType",
                column: "ImageESImageId",
                principalTable: "Image",
                principalColumn: "ESImageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComponentType_Image_ImageESImageId",
                table: "ComponentType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Image",
                table: "Image");

            migrationBuilder.RenameTable(
                name: "Image",
                newName: "ESImage");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ESImage",
                table: "ESImage",
                column: "ESImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComponentType_ESImage_ImageESImageId",
                table: "ComponentType",
                column: "ImageESImageId",
                principalTable: "ESImage",
                principalColumn: "ESImageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
