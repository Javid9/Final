using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchEndProject.Migrations
{
    public partial class AddedContactInfoTableProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "ContactInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "ContactInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "ContactInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "ContactInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tweeter",
                table: "ContactInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wahtsapp",
                table: "ContactInfos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "Linkedin",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "Tweeter",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "Wahtsapp",
                table: "ContactInfos");
        }
    }
}
