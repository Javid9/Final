using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchEndProject.Migrations
{
    public partial class AddedBlogTableProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Blogs");
        }
    }
}
