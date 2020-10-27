using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchEndProject.Migrations
{
    public partial class CreatedCountryTableAndEditJobTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Jobs");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CountryId",
                table: "Jobs",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Countries_CountryId",
                table: "Jobs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Countries_CountryId",
                table: "Jobs");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_CountryId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Jobs");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
