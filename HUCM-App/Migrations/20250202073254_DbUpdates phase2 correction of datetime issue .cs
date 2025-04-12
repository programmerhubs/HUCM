using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HUCM_App.Migrations
{
    public partial class DbUpdatesphase2correctionofdatetimeissue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedDate",
                table: "Usertbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "Usertbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedDate",
                table: "TableHandlersTbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "TableHandlersTbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<int>(
                name: "Tableid",
                table: "TableHandlersTbl",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedDate",
                table: "TableHandlerHistoriesTbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "TableHandlerHistoriesTbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<int>(
                name: "Tableid",
                table: "TableHandlerHistoriesTbl",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedDate",
                table: "SkillsTbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "SkillsTbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedDate",
                table: "ResignsTbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "ResignsTbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedDate",
                table: "ProjectsTbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "ProjectsTbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "ProjectsTbl",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Domain",
                table: "ProjectsTbl",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Manager1Id",
                table: "ProjectsTbl",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Manager2Id",
                table: "ProjectsTbl",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Manager3Id",
                table: "ProjectsTbl",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "ProjectsTbl",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "URI",
                table: "ProjectsTbl",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedDate",
                table: "EmpRolesTbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "EmpRolesTbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedDate",
                table: "Employeestbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "Employeestbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedDate",
                table: "EmployeeJourneystbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "EmployeeJourneystbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedDate",
                table: "Departmentstbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "Departmentstbl",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tableid",
                table: "TableHandlersTbl");

            migrationBuilder.DropColumn(
                name: "Tableid",
                table: "TableHandlerHistoriesTbl");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "ProjectsTbl");

            migrationBuilder.DropColumn(
                name: "Domain",
                table: "ProjectsTbl");

            migrationBuilder.DropColumn(
                name: "Manager1Id",
                table: "ProjectsTbl");

            migrationBuilder.DropColumn(
                name: "Manager2Id",
                table: "ProjectsTbl");

            migrationBuilder.DropColumn(
                name: "Manager3Id",
                table: "ProjectsTbl");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "ProjectsTbl");

            migrationBuilder.DropColumn(
                name: "URI",
                table: "ProjectsTbl");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Usertbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Usertbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "TableHandlersTbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TableHandlersTbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "TableHandlerHistoriesTbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TableHandlerHistoriesTbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "SkillsTbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SkillsTbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "ResignsTbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ResignsTbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "ProjectsTbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ProjectsTbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "ProjectsTbl",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "EmpRolesTbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmpRolesTbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Employeestbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employeestbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "EmployeeJourneystbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeeJourneystbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Departmentstbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departmentstbl",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

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
    }
}
