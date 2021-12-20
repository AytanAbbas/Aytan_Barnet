using Microsoft.EntityFrameworkCore.Migrations;

namespace Barnet.Migrations
{
    public partial class typeupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ntext",
                table: "Services",
                newName: "Content");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Services",
                type: "ntext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Services",
                newName: "ntext");

            migrationBuilder.AlterColumn<string>(
                name: "ntext",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldNullable: true);
        }
    }
}
