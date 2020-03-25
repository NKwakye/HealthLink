using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthLink.Migrations
{
    public partial class AddIsDonortoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDonor",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserRole",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDonor",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "AspNetUsers");
        }
    }
}
