using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMD.Entities
{
    [Table("DoctorComment")]
    public class DoctorComment
    {
        [ForeignKey("Appointment")]
        public int AppointmentId { get; set; }
        [Key]
        public string CommentPrivate { get; set; }

    }
}
