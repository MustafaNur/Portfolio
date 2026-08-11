using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Business.Concrete
{
    public class CertificateManager : ICertificateService
    {
        private readonly IGenericRepository<Certificate> _certificateRepository;
        public CertificateManager(IGenericRepository<Certificate> certificateRepository)
        {
            _certificateRepository = certificateRepository;
        }
        

        public void TDelete(Certificate entity)
        {
            _certificateRepository.Delete(entity);
        }

        public List<Certificate> TGetAll()
        {
            return _certificateRepository.GetAll();
        }

        public Certificate TGetById(int id)
        {
            return _certificateRepository.GetById(id);
        }

        public void TInsert(Certificate entity)
        {
            _certificateRepository.Insert(entity);
        }

        public void TUpdate(Certificate entity)
        {
            _certificateRepository.Update(entity);
        }
    }
}