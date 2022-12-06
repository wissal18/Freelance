using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Models
{
    public class Projects_Talents
    {
        public int ProjectID { get; set; }
        public Project Project { get; set; }

        public int TalentID { get; set; }
        public Talent Talent { get; set; }


    }
}
