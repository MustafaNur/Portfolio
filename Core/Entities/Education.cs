using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Education
    {
        public int EducationID { get; set; }
        public string? EducationTitle { get; set; }
        public string? EducationInstitution { get; set; }
        public string? EducationDescription { get; set; }
        public DateTime? EducationStartDate { get; set; }
        public DateTime? EducationEndDate { get; set; }
    }
}