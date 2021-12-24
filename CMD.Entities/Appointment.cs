using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMD.Entities
{
    [Table("Appointment")]
    public class Appointment
    {
        

        [ForeignKey("Doctor")]
        
        public int DoctorId { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        [Required]
        [Key]
        [Column(TypeName = "int")]
        public int AppointmentId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string AppointmentDate { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string AppointmentTime { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string CommentPublic { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string TypesOfInjury { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int CurrentStatus { get; set; }
        
    }
}
