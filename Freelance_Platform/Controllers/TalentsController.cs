using Freelance_Platform.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Controllers
{
    public class TalentsController : Controller
    {
        private readonly AppDBContext _context;
        public TalentsController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allTalents = await _context.Talents.ToListAsync();
            return View();
        }
    }
}
