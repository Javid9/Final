using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchEndProject.Migrations
{
    public partial class AppUseAndEmployerTableRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Employers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employers_AppUserId",
                table: "Employers",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employers_AspNetUsers_AppUserId",
                table: "Employers",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employers_AspNetUsers_AppUserId",
                table: "Employers");

            migrationBuilder.DropIndex(
                name: "IX_Employers_AppUserId",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Employers");
        }
    }
}
