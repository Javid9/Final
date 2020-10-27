using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchEndProject.Migrations
{
    public partial class CreatedEducationLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationLevelId",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EducationLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_EducationLevelId",
                table: "Jobs",
                column: "EducationLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_EducationLevels_EducationLevelId",
                table: "Jobs",
                column: "EducationLevelId",
                principalTable: "EducationLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_EducationLevels_EducationLevelId",
                table: "Jobs");

            migrationBuilder.DropTable(
                name: "EducationLevels");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_EducationLevelId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "EducationLevelId",
                table: "Jobs");
        }
    }
}
