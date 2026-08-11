using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Experience
    {
        public int ExperienceID { get; set; }
        public string? ExperienceTitle { get; set; }
        public string? ExperienceInstitution { get; set; }
        public string? ExperienceDescription { get; set; }
        public DateTime? ExperienceStartDate { get; set; }
        public DateTime? ExperienceEndDate { get; set; }
    }
}