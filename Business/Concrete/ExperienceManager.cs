using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Business.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IGenericRepository<Experience> _experienceRepository;

        public ExperienceManager(IGenericRepository<Experience> experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        public void TDelete(Experience entity)
        {
            _experienceRepository.Delete(entity);
        }

        public List<Experience> TGetAll()
        {
            return _experienceRepository.GetAll();
        }

        public Experience TGetById(int id)
        {
            return _experienceRepository.GetById(id);
        }

        public void TInsert(Experience entity)
        {
            _experienceRepository.Insert(entity);
        }

        public void TUpdate(Experience entity)
        {
            _experienceRepository.Update(entity);
        }
    }
}
