using Freelance_Platform.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Models
{
    public class Talent
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Title")]
        public string Title { get; set; }
        [Display(Name ="Category")]
        public TalentCategory Category { get; set; }
        public List<Projects_Talents> Projects_Talents { get; set; }
        public List<Freelancers_Talents> Freelancers_Talents { get; set; }

    }
}
