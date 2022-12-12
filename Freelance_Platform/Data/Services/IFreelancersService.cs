using Freelance_Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Data.Services
{
   public interface IFreelancersService
    {
        Task<IEnumerable<Freelancer>> GetAll();
        Freelancer GetById(int id);
        void Add(Freelancer freelancer);
        Freelancer Update(int id, Freelancer newFreelancer);
        void Delete(int id);
    }
}
