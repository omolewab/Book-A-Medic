using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAMedic.Models;
using CapstoneBvia.Data;
using CapstoneBvia.Models;
using CapstoneBvia.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CapstoneBvia.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ILogger<DoctorController> logger;
        private readonly DataContext dbContext;
        

        public DoctorController(ILogger<DoctorController> _logger, DataContext _dataContext)
        {
            logger = _logger;
            dbContext = _dataContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            int userId= Int32.Parse(HttpContext.Session.GetInt32("UserId").ToString());
            ViewBag.DoctorName = HttpContext.Session.GetString("FullName");

            List<seeappointmentdoctorswithpatients> model = new List<seeappointmentdoctorswithpatients>();
            var joined = (from appointmentss in dbContext.Appointments 
                          join patientss in dbContext.Patients
                          on appointmentss.Patients_Id equals patientss.Patients_Id
                          where userId.Equals(2)
                          select new 
                          { 
                              patname = patientss.Firstname, 
                              appdate = appointmentss.Date, 
                              apptime = appointmentss.Time 
                          }).ToList();

            foreach(var item in joined)
            {
                model.Add(new seeappointmentdoctorswithpatients()
                {
                    patname = item.patname,
                    appdate = item.appdate,
                    apptime = item.apptime,

                });
            }
 
            return View(model);
        }
       


    }
}
