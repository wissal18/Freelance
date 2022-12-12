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
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        [Display(Name = "Country")]
        public string Country { get; set; }
        [Display(Name = "Price Per Hour")]
        public int PricePerHour { get; set; }

        public List<Freelancers_Talents> Freelancers_Talents { get; set; }

    }
}
