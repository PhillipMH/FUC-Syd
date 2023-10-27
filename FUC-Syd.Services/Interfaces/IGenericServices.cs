using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace FUC_Syd.Services.Interfaces
{
    public interface IGenericServices<DTO> where DTO : class
    {
        Task CreateAsync(DTO entity);

        Task DeleteAsync(DTO entity);

        Task<ObservableCollection<DTO>> GetAllAsync();

        Task UpdateAsync(DTO entity);
    }
}
