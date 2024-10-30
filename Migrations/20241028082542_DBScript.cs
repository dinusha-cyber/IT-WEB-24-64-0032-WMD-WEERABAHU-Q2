using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Q2.Migrations
{
    /// <inheritdoc />
    public partial class DBScript : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
