using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HUCM_App.Models
{
	public enum empStatus
	{
		Active=1,
		Exit=0,
		Resign=2,
		Revoke=3,
		Terminate=4,
	}
	public class Resign: BaseEntity
	{
		[Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int ResignId { get; set; }
		public int EmpId { get; set; }
		public ResignReason ?Reason1 { get; set; }
        public ResignReason? Reason2 { get; set; }
        public ResignReason? Reason3 { get; set; }
		public string ? Description { get; set; }
		public empStatus EmpStatus { get; set; }

    }
	public class ResignReason
	{
		[Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int ReasonId { get; set; }
		public string ? Reason { get; set; }

	}
    
}