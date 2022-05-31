using Microsoft.EntityFrameworkCore.Migrations;

namespace QrCode.Infrastructure.Migrations
{
    public partial class AjoutParameters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PositionX",
                table: "DocumentTypes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PositionY",
                table: "DocumentTypes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Size",
                table: "DocumentTypes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PositionX",
                table: "DocumentTypes");

            migrationBuilder.DropColumn(
                name: "PositionY",
                table: "DocumentTypes");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "DocumentTypes");
        }
    }
}
