using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Entities
{
  
        [Table("Doctor")]
        public class Doctor
        {
        [Required]
        [Key]
            public int DoctorId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string DocEmail { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string NPINo { get; set; }
        [Required]
        public string Experience { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string ProfilePic { get; set; }
        [Required]
        public string Speciality { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        }
    
}
