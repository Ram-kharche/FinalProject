using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Entities
{
    [Table("ActiveIssues")]
    public class ActiveIssues
    {
        [Key]
        public int IssueId { get; set; }
        public string Issues { get; set; }
        [ForeignKey("Patient")]
        public int patientId { get; set; }
    }
}
