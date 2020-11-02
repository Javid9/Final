using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchEndProject.Migrations
{
    public partial class ChangeAppUserPropName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "AspNetUsers",
                newName: "isActivated");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isActivated",
                table: "AspNetUsers",
                newName: "IsDelete");
        }
    }
}
