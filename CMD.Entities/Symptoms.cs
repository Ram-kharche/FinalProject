using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Entities
{
    
    public class Symptoms
    {
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        [Required]
        [Key]
        public int SymtomsId { get; set; }
        [Required]
        public int Symptom { get; set; }
    }
     
}
