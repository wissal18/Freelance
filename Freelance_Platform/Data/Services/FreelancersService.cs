using Freelance_Platform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Data.Services
{
    public class FreelancersService : IFreelancersService
    {
        private readonly AppDBContext _context;
        public FreelancersService(AppDBContext context)
            
        {
            _context = context;

        }
        public void Add(Freelancer freelancer)
        {
            _context.Freelancers.Add(freelancer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Freelancer>> GetAll()
        {
            var result = await _context.Freelancers.ToListAsync();
            return result;
        }

        public Freelancer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Freelancer Update(int id, Freelancer newFreelancer)
        {
            throw new NotImplementedException();
        }
    }
}
