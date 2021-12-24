using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CMD.Entities

{
    [Table("Vital")]
    public class Vital
    {
      

        [ForeignKey("AppointmentId")]
        public int Appointment { get; set; }

       [Key]
        public int ECG { get; set; }
        
        public int Temperature { get; set; }
       
        public int Diabetes { get; set; }
        
        public int RespirationRate { get; set; }

        public virtual ICollection<Vital> Vitals { get; set; }

    }
}
