using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CMD.Entities
{
    [Table("Patient")]
    public class Patient
    {
        [Required]
        [ForeignKey("Doctor")]
        public int Doctorid { get; set; }
        [Required]
       [Key]
        public int Patientid { get; set; }
        [Required]
       
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
       
        [Column(TypeName = "nvarchar")]
        public string Email { get; set; }
        [Required]
       
        [Column(TypeName = "date")]
        public DateTime Patient_DOB { get; set; }
        [Required]
        
        [Column(TypeName = "varchar")]
        public int Patient_Age { get; set; }
        [Required]
       
        [Column(TypeName = "varchar")]
        public string Patient_BloodGroup { get; set; }
        [Required]
        
        [Column(TypeName = "varchar")]
        public string Patient_Gender { get; set; }
        [Required]
        
        [Column(TypeName = "nchar")]
        public Int64 Patient_Phno { get; set; }
        [Required]
        
        [Column(TypeName ="nchar")]
        public int Height { get; set; }


        public virtual ICollection<Patient>Patients{ get; set; }
    }
}
