using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Business.Interfaces
{
    public interface IPortfolioService
    {
        List<Portfolio> TGetAll();
        Portfolio TGetById(int id);
        void TInsert(Portfolio entity);
        void TUpdate(Portfolio entity);
        void TDelete(Portfolio entity);
    }
}
