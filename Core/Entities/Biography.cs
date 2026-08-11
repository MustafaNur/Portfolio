using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Biography
    {
        public int BiographyID { get; set; }
        public string? BiographyDetails { get; set; }
        public string? BiographyCV { get; set; }
    }
}