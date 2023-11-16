using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUC_Syd.Domain.Data;
using FUC_Syd.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FUC_Syd.Domain.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly FUC_SydContext _dbcontext;

        protected GenericRepository(FUC_SydContext dbcontex)
        {
            _dbcontext = dbcontex;
        }

        public async Task CreateAsync(T entity)
        {
            _dbcontext.Add(entity);
            await _dbcontext.SaveChangesAsync();
        }
        public async Task UpdateAsync(T entity)
        {
            _dbcontext.Set<T>().Attach(entity);
            _dbcontext.Entry(entity).State = EntityState.Modified;
            await _dbcontext.SaveChangesAsync();
        }
        public async Task<ObservableCollection<T>> GetAllAsync()
        {
            ObservableCollection<T> temp = new(await _dbcontext.Set<T>().AsNoTracking().ToListAsync());
            return temp;
        }
        public async Task DeleteAsync(T entity)
        {
            _dbcontext.Remove(entity);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
