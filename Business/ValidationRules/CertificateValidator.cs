using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using FluentValidation;

namespace Business.ValidationRules
{
    public class CertificateValidator : AbstractValidator<Certificate>
    {
        public CertificateValidator()
        {
        }
    }
}