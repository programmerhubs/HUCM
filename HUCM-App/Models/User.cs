using System;
using System.ComponentModel.DataAnnotations;

namespace HUCM_App.Models
{
	public class User:BaseEntity
	{
		[Key]
		public int id { get; set; }
		public string UserName { get; set; } = string.Empty;
	}
}

