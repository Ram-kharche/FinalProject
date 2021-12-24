using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Entities
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        public int Q1 { get; set; }
        public int Q2{get; set;}
        public int Q3{get; set;}
        public int Q4{get; set;}
        public string Comments { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId{get; set;}

        [ForeignKey("Appointment")]
        public int AppointmentId{get; set;}
    }
}
