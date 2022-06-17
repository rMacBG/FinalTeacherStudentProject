using Microsoft.EntityFrameworkCore.Migrations;

namespace TeacherStudentProject.Migrations
{
    public partial class SomeThings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpecialityId",
                table: "Specialities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GradeId",
                table: "Grades",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_SpecialityId",
                table: "Specialities",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_GradeId",
                table: "Grades",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Grades_GradeId",
                table: "Grades",
                column: "GradeId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Grades_GradeId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_Specialities_SpecialityId",
                table: "Specialities");

            migrationBuilder.DropIndex(
                name: "IX_Specialities_SpecialityId",
                table: "Specialities");

            migrationBuilder.DropIndex(
                name: "IX_Grades_GradeId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "Specialities");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Grades");
        }
    }
}
