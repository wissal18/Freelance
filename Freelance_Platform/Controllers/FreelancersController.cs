using Freelance_Platform.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Index()
        {
            var allFreelancers = await _context.Freelancers.ToListAsync();
            return View("Index1",allFreelancers);
        }
    }
}
