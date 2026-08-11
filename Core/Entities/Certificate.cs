using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Certificate
    {
        public int CertificateID { get; set; }
        public string? CertificateTitle { get; set; }
        public string? CertificateInstitution { get; set; }
        public DateTime? CertificateDate { get; set; }
        public string? CertificateDescription { get; set; }
    }
}