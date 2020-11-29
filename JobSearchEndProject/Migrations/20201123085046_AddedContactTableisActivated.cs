using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchEndProject.Migrations
{
    public partial class AddedContactTableisActivated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Headers");

            migrationBuilder.AddColumn<bool>(
                name: "isactivated",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isactivated",
                table: "Contacts");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Headers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
