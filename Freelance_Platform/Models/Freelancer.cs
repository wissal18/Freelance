using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Models
{
    public class Freelancer
    {
        [Key]
        public int FreelancerID { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string Country { get; set; }
        public int PricePerHour { get; set; }

        public List<Freelancers_Talents> Freelancers_Talents { get; set; }

    }
}
