using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HUCM_App.Migrations
{
    public partial class DbUpdatesphase1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmentstbl",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DepartmentName = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmentstbl", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeJourneystbl",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    EmpUserName = table.Column<string>(type: "text", nullable: true),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    DOJ = table.Column<DateOnly>(type: "date", nullable: false),
                    Exp = table.Column<float>(type: "real", nullable: false),
                    Manager = table.Column<int>(type: "integer", nullable: false),
                    DepartId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeStatus = table.Column<int>(type: "integer", nullable: false),
                    ExitDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CompanyMail = table.Column<string>(type: "text", nullable: true),
                    PrimaryContact = table.Column<string>(type: "text", nullable: true),
                    SecondaryContact = table.Column<string>(type: "text", nullable: true),
                    PrimaryEmail = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "EmpPwdsTbl",
                columns: table => new
                {
                    EmpID = table.Column<int>(type: "integer", nullable: false),
                    LoginPass = table.Column<string>(type: "text", nullable: true),
                    VerifictionCode = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "EmpRolesTbl",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleName = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpRolesTbl", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "ResignReasonsTbl",
                columns: table => new
                {
                    ReasonId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reason = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResignReasonsTbl", x => x.ReasonId);
                });

            migrationBuilder.CreateTable(
                name: "TableHandlerHistoriesTbl",
                columns: table => new
                {
                    HandlerId = table.Column<int>(type: "integer", nullable: false),
                    sequence = table.Column<int>(type: "integer", nullable: false),
                    ColName = table.Column<string>(type: "text", nullable: true),
                    DisplayName = table.Column<string>(type: "text", nullable: true),
                    ColType = table.Column<string>(type: "text", nullable: true),
                    IsRequired = table.Column<bool>(type: "boolean", nullable: false),
                    Types = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TableHandlersTbl",
                columns: table => new
                {
                    HandlerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sequence = table.Column<int>(type: "integer", nullable: false),
                    ColName = table.Column<string>(type: "text", nullable: true),
                    DisplayName = table.Column<string>(type: "text", nullable: true),
                    ColType = table.Column<string>(type: "text", nullable: true),
                    IsRequired = table.Column<bool>(type: "boolean", nullable: false),
                    Types = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableHandlersTbl", x => x.HandlerId);
                });

            migrationBuilder.CreateTable(
                name: "Employeestbl",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    EmpUserName = table.Column<string>(type: "text", nullable: true),
                    RoleId1 = table.Column<int>(type: "integer", nullable: true),
                    DOJ = table.Column<DateOnly>(type: "date", nullable: false),
                    Exp = table.Column<float>(type: "real", nullable: false),
                    Manager = table.Column<int>(type: "integer", nullable: false),
                    DepartIdDeptId = table.Column<int>(type: "integer", nullable: true),
                    EmployeeStatus = table.Column<int>(type: "integer", nullable: true),
                    ExitDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CompanyMail = table.Column<string>(type: "text", nullable: true),
                    PrimaryContact = table.Column<string>(type: "text", nullable: true),
                    SecondaryContact = table.Column<string>(type: "text", nullable: true),
                    PrimaryEmail = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeestbl", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employeestbl_Departmentstbl_DepartIdDeptId",
                        column: x => x.DepartIdDeptId,
                        principalTable: "Departmentstbl",
                        principalColumn: "DeptId");
                    table.ForeignKey(
                        name: "FK_Employeestbl_EmpRolesTbl_RoleId1",
                        column: x => x.RoleId1,
                        principalTable: "EmpRolesTbl",
                        principalColumn: "RoleId");
                });

            migrationBuilder.CreateTable(
                name: "ResignsTbl",
                columns: table => new
                {
                    ResignId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpId = table.Column<int>(type: "integer", nullable: false),
                    Reason1ReasonId = table.Column<int>(type: "integer", nullable: true),
                    Reason2ReasonId = table.Column<int>(type: "integer", nullable: true),
                    Reason3ReasonId = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    EmpStatus = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResignsTbl", x => x.ResignId);
                    table.ForeignKey(
                        name: "FK_ResignsTbl_ResignReasonsTbl_Reason1ReasonId",
                        column: x => x.Reason1ReasonId,
                        principalTable: "ResignReasonsTbl",
                        principalColumn: "ReasonId");
                    table.ForeignKey(
                        name: "FK_ResignsTbl_ResignReasonsTbl_Reason2ReasonId",
                        column: x => x.Reason2ReasonId,
                        principalTable: "ResignReasonsTbl",
                        principalColumn: "ReasonId");
                    table.ForeignKey(
                        name: "FK_ResignsTbl_ResignReasonsTbl_Reason3ReasonId",
                        column: x => x.Reason3ReasonId,
                        principalTable: "ResignReasonsTbl",
                        principalColumn: "ReasonId");
                });

            migrationBuilder.CreateTable(
                name: "ProjectsTbl",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    EmployeeId = table.Column<int>(type: "integer", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsTbl", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_ProjectsTbl_Employeestbl_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employeestbl",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "SkillsTbl",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    EmployeeId = table.Column<int>(type: "integer", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsTbl", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_SkillsTbl_Employeestbl_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employeestbl",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employeestbl_DepartIdDeptId",
                table: "Employeestbl",
                column: "DepartIdDeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Employeestbl_RoleId1",
                table: "Employeestbl",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsTbl_EmployeeId",
                table: "ProjectsTbl",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResignsTbl_Reason1ReasonId",
                table: "ResignsTbl",
                column: "Reason1ReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_ResignsTbl_Reason2ReasonId",
                table: "ResignsTbl",
                column: "Reason2ReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_ResignsTbl_Reason3ReasonId",
                table: "ResignsTbl",
                column: "Reason3ReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsTbl_EmployeeId",
                table: "SkillsTbl",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeJourneystbl");

            migrationBuilder.DropTable(
                name: "EmpPwdsTbl");

            migrationBuilder.DropTable(
                name: "ProjectsTbl");

            migrationBuilder.DropTable(
                name: "ResignsTbl");

            migrationBuilder.DropTable(
                name: "SkillsTbl");

            migrationBuilder.DropTable(
                name: "TableHandlerHistoriesTbl");

            migrationBuilder.DropTable(
                name: "TableHandlersTbl");

            migrationBuilder.DropTable(
                name: "ResignReasonsTbl");

            migrationBuilder.DropTable(
                name: "Employeestbl");

            migrationBuilder.DropTable(
                name: "Departmentstbl");

            migrationBuilder.DropTable(
                name: "EmpRolesTbl");
        }
    }
}
