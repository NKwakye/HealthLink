using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthLink.Migrations
{
    public partial class AddHospitalToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    WebsiteUrl = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    HospitalName = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hospitals");
        }
    }
}
