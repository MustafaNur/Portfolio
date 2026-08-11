using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string? ServiceTitle { get; set; }
        public string? ServiceDescription { get; set; }
    }
}