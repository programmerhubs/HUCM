using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HUCM_App.Models
{
	public class Project:BaseEntity
	{
		[Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }
		public string ?Name { get; set; }
		public int ManagerId { get; set; }//Project Manager
		public int Manager1Id { get; set; }//Floor Manager
        public int Manager2Id { get; set; }//Team Leader
        public int Manager3Id { get; set; }//Director Manager
		public int ClientId { get; set; }
		public string? URI { get; set; }
		public string? Domain { get; set; }



    }
}

