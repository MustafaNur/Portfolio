using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Business.Interfaces
{
    public interface IContactService
    {
        List<Contact> TGetAll();
        Contact TGetById(int id);
        void TInsert(Contact entity);
        void TUpdate(Contact entity);
        void TDelete(Contact entity);
    }
}
