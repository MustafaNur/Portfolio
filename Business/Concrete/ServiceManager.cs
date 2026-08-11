using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IGenericRepository<Service> _serviceRepository;

        public ServiceManager(IGenericRepository<Service> serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public void TDelete(Service entity)
        {
            _serviceRepository.Delete(entity);
        }

        public List<Service> TGetAll()
        {
            return _serviceRepository.GetAll();
        }

        public Service TGetById(int id)
        {
            return _serviceRepository.GetById(id);
        }

        public void TInsert(Service entity)
        {
            _serviceRepository.Insert(entity);
        }

        public void TUpdate(Service entity)
        {
            _serviceRepository.Update(entity);
        }
    }
}
