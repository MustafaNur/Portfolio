using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Business.Interfaces
{
    public interface IEducationService
    {
        List<Education> TGetAll();
        Education TGetById(int id);
        void TInsert(Education entity);
        void TUpdate(Education entity);
        void TDelete(Education entity);
    }
}
