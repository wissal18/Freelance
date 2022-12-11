using Freelance_Platform.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly AppDBContext _context;
        public ProjectsController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProjects = await _context.Projects.Include(n=>n.Client).ToListAsync();
            return View(allProjects);
        }
    }
}
