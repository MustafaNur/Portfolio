using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Business.Concrete
{
    public class BiographyManager : IBiographyService
    {
        private readonly IGenericRepository<Biography> _biographyRepository;

        public BiographyManager(IGenericRepository<Biography> biographyRepository)
        {
            _biographyRepository = biographyRepository;
        }

        public Task<List<Biography>?> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void TDelete(Biography entity)
        {
            _biographyRepository.Delete(entity);
        }

        public List<Biography> TGetAll()
        {
            return _biographyRepository.GetAll();
        }

        public Biography TGetById(int id)
        {
            return _biographyRepository.GetById(id);
        }

        public void TInsert(Biography entity)
        {
            _biographyRepository.Insert(entity);
        }

        public void TUpdate(Biography entity)
        {
            _biographyRepository.Update(entity);
        }
    }
}