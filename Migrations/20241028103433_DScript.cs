using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Q2.Migrations
{
    /// <inheritdoc />
    public partial class DScript : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_course_StudentID",
                table: "course",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_course_Student_StudentID",
                table: "course",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_course_Student_StudentID",
                table: "course");

            migrationBuilder.DropIndex(
                name: "IX_course_StudentID",
                table: "course");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "course");
        }
    }
}
