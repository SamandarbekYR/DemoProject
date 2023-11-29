using DemoProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task AddAsync(TEntity entity);
        Task<TEntity> GetByIdAysnc(Guid id);
        Task Delete(Guid id);
        void UpdateAsync(TEntity entity);
        Task<IQueryable<TEntity>> GetAll();
    }
}
