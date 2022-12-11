using Freelance_Platform.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Controllers
{
    public class ClientsController : Controller
    {
        private readonly AppDBContext _context;

        public ClientsController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allClients = await _context.Clients.ToListAsync();
            return View();
        }
    }
}
