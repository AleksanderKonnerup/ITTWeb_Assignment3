using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class NewModelz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComponentIds",
                table: "ComponentType");

            migrationBuilder.DropColumn(
                name: "ComponentTypeId",
                table: "Component");

            migrationBuilder.AddColumn<string>(
                name: "ComponentTypeIds",
                table: "Component",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComponentTypeIds",
                table: "Component");

            migrationBuilder.AddColumn<string>(
                name: "ComponentIds",
                table: "ComponentType",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ComponentTypeId",
                table: "Component",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
