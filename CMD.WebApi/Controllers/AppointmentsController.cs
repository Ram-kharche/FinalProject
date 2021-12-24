using CMD.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMD.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly CMDWebApiContext db;

        public AppointmentsController(CMDWebApiContext db)
        {
            this.db = db;
        }
        public List<Appointment> GetAppointment(int Id)
        {
            
            return  db.Appointments.Where(d => d.DoctorId == Id).ToList();
            
        }
        
    }
}
