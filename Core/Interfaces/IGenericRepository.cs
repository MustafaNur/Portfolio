using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        // Okuma İşlemleri
        List<T> GetAll();
        T GetById(int id);
        List<T> GetByFilter(Expression<Func<T, bool>> filter); // Filtrelemeli listeleme için
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}