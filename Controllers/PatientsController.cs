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
    public class PatientsController : Controller
    {
        private readonly ILogger<PatientsController> logger;
        private readonly DataContext dbContext;
        public PatientsController(ILogger<PatientsController> _logger, DataContext _dataContext)
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
