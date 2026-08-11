using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Business.Concrete
{
    public class SkillManager : ISkillService
    {
        private readonly IGenericRepository<Skill> _skillRepository;

        public SkillManager(IGenericRepository<Skill> skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public void TDelete(Skill entity)
        {
            _skillRepository.Delete(entity);
        }

        public List<Skill> TGetAll()
        {
            return _skillRepository.GetAll();
        }

        public Skill TGetById(int id)
        {
            return _skillRepository.GetById(id);
        }

        public void TInsert(Skill entity)
        {
            _skillRepository.Insert(entity);
        }

        public void TUpdate(Skill entity)
        {
            _skillRepository.Update(entity);
        }
    }
}
