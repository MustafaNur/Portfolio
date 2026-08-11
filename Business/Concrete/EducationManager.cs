using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Business.Concrete
{
    public class EducationManager : IEducationService
    {
        private readonly IGenericRepository<Education> _educationRepository;

        public EducationManager(IGenericRepository<Education> educationRepository)
        {
            _educationRepository = educationRepository;
        }

        public void TDelete(Education entity)
        {
            _educationRepository.Delete(entity);
        }

        public List<Education> TGetAll()
        {
            return _educationRepository.GetAll();
        }

        public Education TGetById(int id)
        {
            return _educationRepository.GetById(id);
        }

        public void TInsert(Education entity)
        {
            _educationRepository.Insert(entity);
        }

        public void TUpdate(Education entity)
        {
            _educationRepository.Update(entity);
        }
    }
}
