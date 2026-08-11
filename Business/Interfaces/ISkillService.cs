using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Business.Interfaces
{
    public interface ISkillService
    {
        List<Skill> TGetAll();
        Skill TGetById(int id);
        void TInsert(Skill entity);
        void TUpdate(Skill entity);
        void TDelete(Skill entity);
    }
}
