using Freelance_Platform.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Controllers
{
    public class FreelancersController : Controller
    {
        private readonly AppDBContext _context;

        public FreelancersController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Freelancers.ToList();

            return View();
        }
    }
}
