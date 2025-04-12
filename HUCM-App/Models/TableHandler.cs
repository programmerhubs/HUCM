using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HUCM_App.Models
{
    public enum FieldType
    {
        Column,
        Table
    }
    public class TableHandler :BaseEntity
	{
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int HandlerId { get; set; }
		public int sequence { get; set; }
        public int Tableid { get; set; }
        public string ?ColName { get; set; }
		public string? DisplayName { get; set; }
		public string? ColType { get; set; }
		public bool IsRequired { get; set; }
		public FieldType Types { get; set; } 
	}
    public class TableHandlerHistory : BaseEntity
    {
        public int HandlerId { get; set; }
        public int sequence { get; set; }
        public int Tableid { get; set; }
        public string? ColName { get; set; }
        public string? DisplayName { get; set; }
        public string? ColType { get; set; }
        public bool IsRequired { get; set; }
        public FieldType Types { get; set; }
    }
    public class Table
    {
        public int Tableid { get; set; }
        public string? TableName { get; set; }
    }
}

