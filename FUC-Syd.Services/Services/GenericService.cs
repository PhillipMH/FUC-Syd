using FUC_Syd.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUC_Syd.Services.Interfaces;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FUC_Syd.Services.Services
{
    public class GenericService : IGenericService
    {
        private readonly GenericService _genericRepository;

        protected GenericService(GenericService genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task CreateAsync<Tentity>(Tentity e) where Tentity : class
        {
            await _genericRepository.CreateAsync(e);
        }

        public async Task DeleteAsync<Tentity>(Tentity e) where Tentity : class
        {
            await _genericRepository.DeleteAsync(e);
        }

        public async Task<ObservableCollection<dynamic>> GetAllAsync()
        {
            var entities = await _genericRepository.GetAllAsync();
            var observableCollection = new ObservableCollection<dynamic>(entities);
            return observableCollection;
        }

        public async Task UpdateAsync<Tentity>(Tentity e) where Tentity : class
        {
            await _genericRepository.UpdateAsync(e);
        }
    }


}
