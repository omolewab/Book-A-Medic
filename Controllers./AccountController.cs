using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapstoneBvia.Data;
using CapstoneBvia.Models;
using CapstoneBvia.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CapstoneBvia.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> logger;
        private readonly DataContext dbContext;
        // GET: AccountController
        public AccountController(ILogger<AccountController> _logger, DataContext _dataContext)
        {
            logger = _logger;
            dbContext = _dataContext;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public JsonResult UserLogin(string userName, string password)
        {
            var userCheck = (from user in dbContext.Patients
                             where user.Username.Equals(userName) &&
                             user.Password.Equals(password)
                             select user).FirstOrDefault();
            var userCheckDoctor = (from user in dbContext.Doctors
                             where user.Username.Equals(userName) &&
                             user.Password.Equals(password)
                             select user).FirstOrDefault();
            
            if (userCheck != null)
            {
                HttpContext.Session.SetInt32("UserId", userCheck.Patients_Id);
                return Json("success");
            }
            else if (userCheckDoctor != null)
            {
                HttpContext.Session.SetInt32("UserId", userCheckDoctor.Doctor_Id);
                return Json("success");
            }
            else
            {
                return Json("failed");
            }
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public JsonResult UserRegistration([FromBody] RegistrationViewModel reg)
        {
       
            if (reg.Usertype == "doctor")
            {
                address address = new address();
                address.Address_Line1 = reg.Address1;
                address.Address_Line2 = reg.Address2;
                address.Province = "";
                address.Is_Doctor = 1;
                address.City = reg.Usertype;
                address.Phone_Number = reg.Contact;
                address.Zip = reg.Zip;

                dbContext.Add(address);
                dbContext.SaveChanges();

                Doctors doctor = new Doctors();
                doctor.Address_Address_Id = address.Address_Id;
                doctor.Firstname = reg.FirstName;
                doctor.Lastname = reg.LastName;
                doctor.Departments_Id = 1;
                doctor.Email = reg.Email;
                doctor.Password = reg.Password;
                doctor.Username = reg.Email;
                doctor.Availabilities_Availabilities_Id = 1;

                dbContext.Add(doctor);
                dbContext.SaveChanges();



            }
            else
            {
                address address = new address();
                address.Address_Line1 = reg.Address1;
                address.Address_Line2 = reg.Address2;
                address.Province = "";
                address.Is_Doctor = 0;
                address.City = reg.Usertype;
                address.Phone_Number = reg.Contact;
                address.Zip = reg.Zip;

                dbContext.Add(address);
                dbContext.SaveChanges();

                patients patient = new patients();
                patient.Address = address.Address_Id;
                patient.Firstname = reg.FirstName;
                patient.Lastname = reg.LastName;
                patient.Email = reg.Email;
                patient.Password = reg.Password;
                patient.Username = reg.Email;

                dbContext.Add(patient);
                dbContext.SaveChanges();
            }

            return Json("success");
        }
    }
}
