using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CMD.Entities
{
    [Table("Test")]
    public class Test
    {
        [ForeignKey("Appointment")]
      public int AppointmentId { get; set; }
        [Key]
        public int TestId { get; set; }
         

        public string TestName { get; set; }

        public virtual ICollection<Test> Tests { get; set; }
    }
}
