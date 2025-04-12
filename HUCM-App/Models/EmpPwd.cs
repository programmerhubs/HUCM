using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HUCM_App.Models
{
	public class EmpPwd
	{
		public int EmpID { get; set; }
		public string? LoginPass { get; set; }
		public string ? VerifictionCode { get; set; }
       
    }
    public class Department :BaseEntity
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption:DatabaseGeneratedOption.Identity)]
        public int DeptId { get; set; }
        public string? DepartmentName { get; set; }
    }
    public class EmpRole : BaseEntity
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
    }

}

