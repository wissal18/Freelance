using Freelance_Platform.Data;
using Freelance_Platform.Data.Services;
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
        private readonly IFreelancersService _service;

        public FreelancersController(IFreelancersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allFreelancers = await _service.GetAll();
            return View("Index1",allFreelancers);
        }

        //Get: Freelancers/Create

        public  IActionResult Create()
        {
            return View();
        }
    }
}
