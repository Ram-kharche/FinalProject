using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Entities
{
    [Table("MedicalProblems")]
     public class MedicalProblems
    {
        [Key]
        public int MedicalProbId{get;set;}
        public string problem { get; set; }
        [ForeignKey("Patient")]
        public int patientId { get; set; }

    }
}
