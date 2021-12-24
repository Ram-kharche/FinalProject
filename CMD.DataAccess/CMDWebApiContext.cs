using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Entities
{
    public class CMDWebApiContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        public CMDWebApiContext(DbContextOptions<CMDWebApiContext> options): base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Credentials> Credentials { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorComment> DoctorComments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Symptoms> Symptom { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Vital> Vitals { get; set; }
        public DbSet<ActiveIssues> ActiveIssue { get; set; }
        public DbSet<Allergies> Allergie { get; set; }
        public DbSet<MedicalProblems> MedicalProblem { get; set; }

    }
}
