using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchEndProject.Migrations
{
    public partial class AddedJobApplyUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplyUserId",
                table: "Jobs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_ApplyUserId",
                table: "Jobs",
                column: "ApplyUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_AspNetUsers_ApplyUserId",
                table: "Jobs",
                column: "ApplyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_AspNetUsers_ApplyUserId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_ApplyUserId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "ApplyUserId",
                table: "Jobs");
        }
    }
}
