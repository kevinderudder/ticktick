using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TickTick.Models;

namespace TickTick.Repositories.Base
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();

        // Person q = await repo.GetAsync(p => p.IsDeleted == false);
        // Person q = await repo.GetAsync(T => T.IsDeleted == false);
        // var q = repo.GetAsync(p => p.Id == id);
        // var q = repo.GetAsync(p => p.FirstName == "Kevin" && p.IsDeleted == false);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<int> SaveAsync();
    }
}
