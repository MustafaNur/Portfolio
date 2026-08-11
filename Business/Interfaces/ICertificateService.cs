using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Business.Interfaces
{
    public interface ICertificateService
    {
        List<Certificate> TGetAll();
        Certificate TGetById(int id);
        void TInsert(Certificate entity);
        void TUpdate(Certificate entity);
        void TDelete(Certificate entity);     
    }
}