using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Business.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        private readonly IGenericRepository<Portfolio> _portfolioRepository;

        public PortfolioManager(IGenericRepository<Portfolio> portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
        }

        public void TDelete(Portfolio entity)
        {
            _portfolioRepository.Delete(entity);
        }

        public List<Portfolio> TGetAll()
        {
            return _portfolioRepository.GetAll();
        }

        public Portfolio TGetById(int id)
        {
            return _portfolioRepository.GetById(id);
        }

        public void TInsert(Portfolio entity)
        {
            _portfolioRepository.Insert(entity);
        }

        public void TUpdate(Portfolio entity)
        {
            _portfolioRepository.Update(entity);
        }
    }
}
