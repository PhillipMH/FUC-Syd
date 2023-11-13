using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Domain.Interfaces
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        Task CreateAsync(Entity entity);

        Task UpdateAsync(Entity entity);

        Task DeleteAsync(Entity entity);

        Task<ObservableCollection<Entity>> GetAllAsync();
    }
}
