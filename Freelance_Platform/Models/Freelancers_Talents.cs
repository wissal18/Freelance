using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Models
{
    public class Freelancers_Talents
    {
        public int TalentID { get; set; }
        public Talent Talent { get; set; }

        public Freelancer Freelancer { get; set; }
        public int FreelancerID { get; set; }

    }
}
