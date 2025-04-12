using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HUCM_App.Models
{
    public enum operationType
    {
        add,
        subtract
    }
	public class Formula :BaseEntity
	{
		
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required] 
        [MaxLength(255)] 
        public string ?TableName { get; set; }

        [Required] 
        [MaxLength(50)] 
        public operationType ?OperationType { get; set; } 

        [Required] 
        public List<string> ?ColumnNames { get; set; } 

        [Required]
        public int Sequence { get; set; } 

        public string ?Description { get; set; } 
    
}
}

