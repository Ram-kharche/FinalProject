using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Entities
{
    [Table("Allergies")]
    public class Allergies
    {
        [Key]
        public int AllergieId { get; set; }
        public int AllergieName { get; set; }
        [ForeignKey("Patient")]
        public int patientId { get; set; }
    }
}
