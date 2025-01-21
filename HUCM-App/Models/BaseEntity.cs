using System;
namespace HUCM_App.Models
{
	public class BaseEntity
	{
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }
		public bool IsActive { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime ModifiedDate { get; set; }
	}
}

