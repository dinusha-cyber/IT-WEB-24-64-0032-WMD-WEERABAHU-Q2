using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Q2.Migrations
{
    /// <inheritdoc />
    public partial class RemoveM2MandSetOne2One : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Student_CourseID",
                table: "Student",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_course_CourseID",
                table: "Student",
                column: "CourseID",
                principalTable: "course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_course_CourseID",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_CourseID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Student");

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
    }
}
