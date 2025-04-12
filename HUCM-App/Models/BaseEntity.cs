using System;
namespace HUCM_App.Models
{
	public class BaseEntity
	{
		public string ?CreatedBy { get; set; }
		public string ?ModifiedBy { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public string ?CreatedDate { get; set; }
		public string ?ModifiedDate { get; set; }
	}
	public class SalarySlipBaseEntity :BaseEntity
	{
		public int EmpId { get; set; }
		public int Month { get; set; }
		public int Year { get; set; }

	}
}

