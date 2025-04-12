using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HUCM_App.Models
{
	public class Employee :BaseEntity
	{
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
		public string? Name { get; set; }
        public string? EmpUserName { get; set; }
		public EmpRole? RoleId { get; set; }
		public DateOnly DOJ { get; set; }
		public List<Skill>? Skills {get;set;}
		public float Exp { get; set; }
		public int Manager { get; set; }
		public List<Project> ? Projects { get; set; }
		public Department? DepartId { get; set; }
        public empStatus ?EmployeeStatus { get; set; }
        public DateOnly ExitDate { get; set; }
        public string? CompanyMail { get; set; }
        public string ?PrimaryContact { get; set; }
        public string? SecondaryContact { get; set; }
        public string? PrimaryEmail { get; set; }
    }
    public class EmployeeJourney : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? EmpUserName { get; set; }
        public int RoleId { get; set; }
        public DateOnly DOJ { get; set; }
        public List<Skill>? Skills { get; set; }
        public float Exp { get; set; }
        public int Manager { get; set; }
        public List<Project>? Projects { get; set; }
        public int DepartId { get; set; }
        public empStatus EmployeeStatus { get; set; }
        public DateOnly ExitDate { get; set; }
        public string? CompanyMail { get; set; }
        public string? PrimaryContact { get; set; }
        public string? SecondaryContact { get; set; }
        public string? PrimaryEmail { get; set; }

    }
}

