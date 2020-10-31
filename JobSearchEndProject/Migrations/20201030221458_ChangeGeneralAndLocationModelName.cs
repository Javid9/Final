using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchEndProject.Migrations
{
    public partial class ChangeGeneralAndLocationModelName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apply_Loactions_LoactionId",
                table: "Apply");

            migrationBuilder.DropIndex(
                name: "IX_Apply_LoactionId",
                table: "Apply");

            migrationBuilder.DropColumn(
                name: "LoactionId",
                table: "Apply");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Loactions",
                newName: "Locationn");

            migrationBuilder.RenameColumn(
                name: "Genral",
                table: "Apply",
                newName: "General");

            migrationBuilder.CreateIndex(
                name: "IX_Apply_LocationId",
                table: "Apply",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apply_Loactions_LocationId",
                table: "Apply",
                column: "LocationId",
                principalTable: "Loactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apply_Loactions_LocationId",
                table: "Apply");

            migrationBuilder.DropIndex(
                name: "IX_Apply_LocationId",
                table: "Apply");

            migrationBuilder.RenameColumn(
                name: "Locationn",
                table: "Loactions",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "General",
                table: "Apply",
                newName: "Genral");

            migrationBuilder.AddColumn<int>(
                name: "LoactionId",
                table: "Apply",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Apply_LoactionId",
                table: "Apply",
                column: "LoactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apply_Loactions_LoactionId",
                table: "Apply",
                column: "LoactionId",
                principalTable: "Loactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
