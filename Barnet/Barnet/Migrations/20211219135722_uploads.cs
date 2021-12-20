using Microsoft.EntityFrameworkCore.Migrations;

namespace Barnet.Migrations
{
    public partial class uploads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterLogo",
                table: "Settings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FooterLogo",
                table: "Settings",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }
    }
}
