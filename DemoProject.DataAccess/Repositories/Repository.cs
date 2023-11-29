using DemoProject.DataAccess.AppDbContext;
using DemoProject.DataAccess.Interfaces;
using DemoProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private DbSet<TEntity> _repos;

        public Repository(AppDb appDb)
        {
            this._repos = appDb.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
            => await _repos.AddAsync(entity); 

        public async Task Delete(Guid id)
        {
            var res = await _repos.FirstOrDefaultAsync(r => r.Id == id);
            if(res is not null)
            {
                _repos.Remove(res);
            }
        }

        public async Task<IQueryable<TEntity>> GetAll()
        {
            return  _repos;
        }

        public Task<TEntity> GetByIdAysnc(Guid id)
        {
            return  _repos.FirstOrDefaultAsync(x => x.Id == id)!;
        }

        public  void UpdateAsync(TEntity entity)
        {
           _repos.Update(entity);
        }
    }
}
