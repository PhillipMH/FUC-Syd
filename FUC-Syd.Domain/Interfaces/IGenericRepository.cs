using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Domain.Interfaces
{
    public interface IGenericRepository<E> where E : class
    {
        Task CreateAsync(E entity);

        Task UpdateAsync(E entity);

        Task DeleteAsync(E entity);

        Task<ObservableCollection<E>> GetAllAsync();
    }
}
