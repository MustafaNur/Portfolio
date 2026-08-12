using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Business.Interfaces
{
    public interface IBiographyService
    {
        List<Biography> TGetAll();
        Biography TGetById(int id);
        void TInsert(Biography entity);
        void TUpdate(Biography entity);
        void TDelete(Biography entity);
        Task<List<Biography>?> GetAllAsync();
    }
}