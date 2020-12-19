using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchEndProject.Migrations
{
    public partial class CreatedApplyJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ApplyJobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplyJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplyJobs_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplyJobs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplyJobs_AppUserId",
                table: "ApplyJobs",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplyJobs_JobId",
                table: "ApplyJobs",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplyJobs");

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
    }
}
