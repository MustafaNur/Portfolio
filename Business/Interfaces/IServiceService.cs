using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Business.Interfaces
{
    public interface IServiceService
    {
        List<Service> TGetAll();
        Service TGetById(int id);
        void TInsert(Service entity);
        void TUpdate(Service entity);
        void TDelete(Service entity);
    }
}
