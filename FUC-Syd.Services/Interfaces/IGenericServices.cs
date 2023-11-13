using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace FUC_Syd.Services.Interfaces
{
    public interface IGenericServices<Entity> where Entity : class
    {
        Task CreateAsync(Entity entity);

        Task DeleteAsync(Entity entity);

        Task<ObservableCollection<Entity>> GetAllAsync();

        Task UpdateAsync(Entity entity);
    }
}
