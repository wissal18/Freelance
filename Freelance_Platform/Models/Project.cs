using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Title")]
        public string Title { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public int EstimatedDuration { get; set; }
        public string ExperienceLevel { get; set; }
        [Display(Name = "Post Date")]
        public DateTime PostDate  { get; set; } 
        public string Country { get; set; }

        public List<Projects_Talents> Projects_Talents { get; set; }

        public int ClientID { get; set; }
        [ForeignKey("ClientID")]
        [Display(Name ="Client")]
        public Client Client { get; set; }


    }
}
