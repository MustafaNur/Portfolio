using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Business.Interfaces
{
    public interface IExperienceService
    {
        List<Experience> TGetAll();
        Experience TGetById(int id);
        void TInsert(Experience entity);
        void TUpdate(Experience entity);
        void TDelete(Experience entity);
    }
}
