using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Models
{
    public class Freelancers_Talents
    {
        public int TalentID { get; set; }
        public Talent talent { get; set; }

        public Freelancer freelancer { get; set; }
        public int FreelancerID { get; set; }

    }
}
