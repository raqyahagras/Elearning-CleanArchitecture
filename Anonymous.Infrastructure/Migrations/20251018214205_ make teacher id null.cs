using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anonymous.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class maketeacheridnull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_Teachers_TeacherId",
                table: "courses");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_Teachers_TeacherId",
                table: "courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_Teachers_TeacherId",
                table: "courses");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_courses_Teachers_TeacherId",
                table: "courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
