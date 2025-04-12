using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HUCM_App.Models
{
    public class Skill : BaseEntity
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int SkillId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

}

