using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSearchEndProject.Migrations
{
    public partial class EditApplyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "University",
                table: "Applies",
                newName: "UniversityName");

            migrationBuilder.RenameColumn(
                name: "Graduation",
                table: "Applies",
                newName: "Twitter");

            migrationBuilder.RenameColumn(
                name: "DateTo",
                table: "Applies",
                newName: "StartUniversity");

            migrationBuilder.RenameColumn(
                name: "DateFrom",
                table: "Applies",
                newName: "StartCompanyDate");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "Applies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndCompanyDate",
                table: "Applies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Applies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Google",
                table: "Applies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GraduationDate",
                table: "Applies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Applies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "Applies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "Applies");

            migrationBuilder.DropColumn(
                name: "EndCompanyDate",
                table: "Applies");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Applies");

            migrationBuilder.DropColumn(
                name: "Google",
                table: "Applies");

            migrationBuilder.DropColumn(
                name: "GraduationDate",
                table: "Applies");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Applies");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Applies");

            migrationBuilder.RenameColumn(
                name: "UniversityName",
                table: "Applies",
                newName: "University");

            migrationBuilder.RenameColumn(
                name: "Twitter",
                table: "Applies",
                newName: "Graduation");

            migrationBuilder.RenameColumn(
                name: "StartUniversity",
                table: "Applies",
                newName: "DateTo");

            migrationBuilder.RenameColumn(
                name: "StartCompanyDate",
                table: "Applies",
                newName: "DateFrom");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
