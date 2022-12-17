using Freelance_Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Data.Services
{
   public interface IFreelancersService
    {
        Task<IEnumerable<Freelancer>> GetAllAsync();
        Task<Freelancer> GetByIdAsync(int id);
        Task AddAsync(Freelancer freelancer);
        Task<Freelancer> UpdateAsync(int id, Freelancer newFreelancer);
        void Delete(int id);
    }
}
