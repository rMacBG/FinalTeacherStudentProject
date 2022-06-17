using Microsoft.EntityFrameworkCore.Migrations;

namespace TeacherStudentProject.Migrations
{
    // This here seeds some data in the base if there is nothing added by the user!
    public partial class SpecialityChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_Specialities_SpecialityTypeId",
                table: "Specialities");

            migrationBuilder.RenameColumn(
                name: "SpecialityTypeId",
                table: "Specialities",
                newName: "SpecialityId");

            migrationBuilder.RenameIndex(
                name: "IX_Specialities_SpecialityTypeId",
                table: "Specialities",
                newName: "IX_Specialities_SpecialityId");

            migrationBuilder.AddColumn<string>(
                name: "SpecialityName",
                table: "Specialities",
                type: "nvarchar(max)",
                nullable: true);

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
                name: "FK_Specialities_Specialities_SpecialityId",
                table: "Specialities");

            migrationBuilder.DropColumn(
                name: "SpecialityName",
                table: "Specialities");

            migrationBuilder.RenameColumn(
                name: "SpecialityId",
                table: "Specialities",
                newName: "SpecialityTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Specialities_SpecialityId",
                table: "Specialities",
                newName: "IX_Specialities_SpecialityTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_Specialities_SpecialityTypeId",
                table: "Specialities",
                column: "SpecialityTypeId",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
