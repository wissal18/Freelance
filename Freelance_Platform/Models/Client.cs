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

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string Country { get; set; }

        //Relationships
        public List<Project> Projects { get; set; }


    }
}
