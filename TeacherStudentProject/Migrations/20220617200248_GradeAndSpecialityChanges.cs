using Microsoft.EntityFrameworkCore.Migrations;

namespace TeacherStudentProject.Migrations
{
    public partial class GradeAndSpecialityChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Grades_GradesId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_Specialities_SpecialityId",
                table: "Specialities");

            migrationBuilder.DropIndex(
                name: "IX_Specialities_SpecialityId",
                table: "Specialities");

            migrationBuilder.DropIndex(
                name: "IX_Grades_GradesId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "Specialities");

            migrationBuilder.DropColumn(
                name: "GradesId",
                table: "Grades");

            migrationBuilder.AddColumn<string>(
                name: "Grades",
                table: "Grades",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grades",
                table: "Grades");

            migrationBuilder.AddColumn<string>(
                name: "SpecialityId",
                table: "Specialities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GradesId",
                table: "Grades",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_SpecialityId",
                table: "Specialities",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_GradesId",
                table: "Grades",
                column: "GradesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Grades_GradesId",
                table: "Grades",
                column: "GradesId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_Specialities_SpecialityId",
                table: "Specialities",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
