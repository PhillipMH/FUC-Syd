using System.Collections.ObjectModel;

namespace FUC_Syd.Services.Services
{
    public interface IGenericService
    {
        Task CreateAsync<Tentity>(Tentity e) where Tentity : class;
        Task DeleteAsync<Tentity>(Tentity e) where Tentity : class;
        Task<ObservableCollection<dynamic>> GetAllAsync();
        Task UpdateAsync<Tentity>(Tentity e) where Tentity : class;
    }
}