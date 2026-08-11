using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IGenericRepository<Contact> _contactRepository;

        public ContactManager(IGenericRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void TDelete(Contact entity)
        {
            _contactRepository.Delete(entity);
        }

        public List<Contact> TGetAll()
        {
            return _contactRepository.GetAll();
        }

        public Contact TGetById(int id)
        {
            return _contactRepository.GetById(id);
        }

        public void TInsert(Contact entity)
        {
            _contactRepository.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactRepository.Update(entity);
        }
    }
}
