using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HUCM_App.Migrations
{
    public partial class ProjectUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "ProjectsTbl",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsTbl_EmployeeId",
                table: "ProjectsTbl",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectsTbl_Employeestbl_EmployeeId",
                table: "ProjectsTbl",
                column: "EmployeeId",
                principalTable: "Employeestbl",
                principalColumn: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectsTbl_Employeestbl_EmployeeId",
                table: "ProjectsTbl");

            migrationBuilder.DropIndex(
                name: "IX_ProjectsTbl_EmployeeId",
                table: "ProjectsTbl");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "ProjectsTbl");
        }
    }
}
