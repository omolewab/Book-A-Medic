using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapstoneBvia.Data;
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
        public IActionResult Index()
        {
            return View();
        }


    }
}
