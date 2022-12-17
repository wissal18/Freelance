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
        public async Task AddAsync(Freelancer freelancer)
        {
           await _context.Freelancers.AddAsync(freelancer);
          await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Freelancer>> GetAllAsync()
        {
            var result = await _context.Freelancers.ToListAsync();
            return result;
        }

        public async Task<Freelancer> GetByIdAsync(int id)
        {
            var result = await _context.Freelancers.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Freelancer> UpdateAsync(int id, Freelancer newFreelancer)
        {
            _context.Update(newFreelancer);
            await _context.SaveChangesAsync();
            return newFreelancer;
        }
    }
}
