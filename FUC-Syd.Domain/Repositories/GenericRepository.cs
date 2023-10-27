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
    public abstract class GenericRepository<E> : IGenericRepository<E> where E : class
    {
        private readonly FUC_SydContext _dbcontext;

        protected GenericRepository(FUC_SydContext dbcontex)
        {
            _dbcontext = dbcontex;
        }

        public async Task CreateAsync(E entity)
        {
            _dbcontext.Add(entity);
            await _dbcontext.SaveChangesAsync();
        }
        public async Task UpdateAsync(E entity)
        {
            _dbcontext.Set<E>().Attach(entity);
            _dbcontext.Entry(entity).State = EntityState.Modified;
            await _dbcontext.SaveChangesAsync();
        }
        public async Task<ObservableCollection<E>> GetAllAsync()
        {
            ObservableCollection<E> temp = new(await _dbcontext.Set<E>().AsNoTracking().ToListAsync());
            return temp;
        }
        public async Task DeleteAsync(E entity)
        {
            _dbcontext.Remove(entity);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
