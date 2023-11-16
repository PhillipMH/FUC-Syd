namespace FUC_Syd.Services.Interfaces
{
    public interface IGenericService
    {
        Task CreateAsync<Tentity>(Tentity entity) where Tentity : class;
        Task DeleteAsync<Tentity>(Tentity entity);
        List<object> GetTentities(object entity);
        Task UpdateAsync<Tentity>(Tentity entity);
    }
}