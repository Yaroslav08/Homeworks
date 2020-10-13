using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestLaba.Repositories
{
    public interface IRepository<TEntity, TypeId> where TEntity : class
    {
        Task<TEntity> GetByIdAsTrackingAsync(TypeId Id);
        Task<TEntity> GetByIdAsync(TypeId Id);
        Task<TEntity> GetByWhereAsync(Expression<Func<TEntity, bool>> match);
        Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> CreateAsync(TEntity model);
        Task<TEntity> EditAsync(TEntity model);
        Task RemoveAsync(TEntity model);
        Task SaveAsync();
    }
}