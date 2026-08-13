using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class EducationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EducationDescription",
                table: "Educations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EducationEndDate",
                table: "Educations",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EducationStartDate",
                table: "Educations",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationDescription",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "EducationEndDate",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "EducationStartDate",
                table: "Educations");
        }
    }
}
