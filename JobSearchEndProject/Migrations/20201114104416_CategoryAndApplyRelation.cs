using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchEndProject.Migrations
{
    public partial class CategoryAndApplyRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Applies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Applies_CategoryId",
                table: "Applies",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applies_Categories_CategoryId",
                table: "Applies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applies_Categories_CategoryId",
                table: "Applies");

            migrationBuilder.DropIndex(
                name: "IX_Applies_CategoryId",
                table: "Applies");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Applies");
        }
    }
}
