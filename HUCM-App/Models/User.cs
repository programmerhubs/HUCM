﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HUCM_App.Models
{
	public class User:BaseEntity
	{
		[Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
		public string UserName { get; set; } = string.Empty;
	}
}