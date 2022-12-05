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
        public int TalentID { get; set; }
        public string Title { get; set; }
        public TalentCategory Category { get; set; }
    }
}
