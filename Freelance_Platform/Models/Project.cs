using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Models
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int EstimatedDuration { get; set; }
        public string ExperienceLevel { get; set; }
        public DateTime PostDate  { get; set; }
        public string Country { get; set; }




    }
}
