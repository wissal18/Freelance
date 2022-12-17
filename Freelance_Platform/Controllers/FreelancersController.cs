using Freelance_Platform.Data;
using Freelance_Platform.Data.Services;
using Freelance_Platform.Models;
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
            var allFreelancers = await _service.GetAllAsync();
            return View("Index1",allFreelancers);
        }

        //Get: Freelancers/Create

        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio,Country,PricePerHour")]Freelancer freelancer)
        {
            if (!ModelState.IsValid)
            {
                return View(freelancer);
            }
          await _service.AddAsync(freelancer);
            return RedirectToAction(nameof(Index));

             
        }
        //Get: Actors/Details/
        public async Task<IActionResult> Details(int id)
        {
            var freelancerDetails =await _service.GetByIdAsync(id);
            if (freelancerDetails == null) return View("NotFound");
            return View(freelancerDetails);
        }

        //Get: Freelancers/Edit

        public async Task <IActionResult> Edit(int id)
        {
            var freelancerDetails = await _service.GetByIdAsync(id);
            if (freelancerDetails == null) return View("NotFound");

            return View(freelancerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio,Country,PricePerHour")] Freelancer freelancer)
        {
            if (!ModelState.IsValid)
            {
                return View(freelancer);
            }
            await _service.UpdateAsync(id, freelancer);
            return RedirectToAction(nameof(Index));


        }

    }
}
