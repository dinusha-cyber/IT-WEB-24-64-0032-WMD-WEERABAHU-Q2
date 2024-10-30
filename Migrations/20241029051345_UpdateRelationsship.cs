using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Q2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationsship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_course_CourseID",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Student",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_CourseID",
                table: "Student",
                newName: "IX_Student_CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_course_CourseId",
                table: "Student",
                column: "CourseId",
                principalTable: "course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_course_CourseId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Student",
                newName: "CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_Student_CourseId",
                table: "Student",
                newName: "IX_Student_CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_course_CourseID",
                table: "Student",
                column: "CourseID",
                principalTable: "course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
