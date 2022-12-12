using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Display(Name ="Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        [Display(Name = "Country")]
        public string Country { get; set; }

        //Relationships
        public List<Project> Projects { get; set; }


    }
}
