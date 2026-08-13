using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Portfolio
    {
        public int PortfolioID { get; set; }
        public string? PortfolioTitle { get; set; }
        public string? PortfolioDescription { get; set; }
        public string? PortfolioImage { get; set; }
        public string? PortfolioLink { get; set; }
        public bool IsActive { get; set; } = true;
    }
}