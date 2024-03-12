using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _43_Paskaita_Exam_Databases.Migrations
{
    /// <inheritdoc />
    public partial class PropertiesAmended : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentLecture_Lectures_LecturesLectureId",
                table: "DepartmentLecture");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureStudent_Lectures_LecturesLectureId",
                table: "LectureStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureStudent_Students_StudentsStudentId",
                table: "LectureStudent");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StudentsStudentId",
                table: "LectureStudent",
                newName: "StudentsId");

            migrationBuilder.RenameColumn(
                name: "LecturesLectureId",
                table: "LectureStudent",
                newName: "LecturesId");

            migrationBuilder.RenameIndex(
                name: "IX_LectureStudent_StudentsStudentId",
                table: "LectureStudent",
                newName: "IX_LectureStudent_StudentsId");

            migrationBuilder.RenameColumn(
                name: "LectureId",
                table: "Lectures",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LecturesLectureId",
                table: "DepartmentLecture",
                newName: "LecturesId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentLecture_LecturesLectureId",
                table: "DepartmentLecture",
                newName: "IX_DepartmentLecture_LecturesId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentLecture_Lectures_LecturesId",
                table: "DepartmentLecture",
                column: "LecturesId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureStudent_Lectures_LecturesId",
                table: "LectureStudent",
                column: "LecturesId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureStudent_Students_StudentsId",
                table: "LectureStudent",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentLecture_Lectures_LecturesId",
                table: "DepartmentLecture");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureStudent_Lectures_LecturesId",
                table: "LectureStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_LectureStudent_Students_StudentsId",
                table: "LectureStudent");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "LectureStudent",
                newName: "StudentsStudentId");

            migrationBuilder.RenameColumn(
                name: "LecturesId",
                table: "LectureStudent",
                newName: "LecturesLectureId");

            migrationBuilder.RenameIndex(
                name: "IX_LectureStudent_StudentsId",
                table: "LectureStudent",
                newName: "IX_LectureStudent_StudentsStudentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Lectures",
                newName: "LectureId");

            migrationBuilder.RenameColumn(
                name: "LecturesId",
                table: "DepartmentLecture",
                newName: "LecturesLectureId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentLecture_LecturesId",
                table: "DepartmentLecture",
                newName: "IX_DepartmentLecture_LecturesLectureId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentLecture_Lectures_LecturesLectureId",
                table: "DepartmentLecture",
                column: "LecturesLectureId",
                principalTable: "Lectures",
                principalColumn: "LectureId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureStudent_Lectures_LecturesLectureId",
                table: "LectureStudent",
                column: "LecturesLectureId",
                principalTable: "Lectures",
                principalColumn: "LectureId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LectureStudent_Students_StudentsStudentId",
                table: "LectureStudent",
                column: "StudentsStudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
