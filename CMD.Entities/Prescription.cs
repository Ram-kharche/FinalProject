using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CMD.Entities
{
    [Table("Prescription")]
    public class Prescription
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        [Key]
        public string MedName { get; set; }
        public int Duration { get; set; }
        public string Cycle { get; set; }
        public string Description { get; set; }
        public int AppointmentId { get; set; }
        public string DoseStrength { get; set; }
        public int Price { get; set; }
        public string Food { get; set; }
      
       public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
