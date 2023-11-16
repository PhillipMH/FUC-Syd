using FUC_Syd.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUC_Syd.Services.Interfaces;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using FUC_Syd.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace FUC_Syd.Services.Services
{
    public class GenericService : IGenericService
    {
        private readonly DbContext _genericRepository;
        public readonly MappingService _mappingService;

        protected GenericService(MappingService mappingService, DbContext genericService)
        {
            _genericRepository = genericService;
            _mappingService = mappingService;
        }

        public async Task CreateAsync<Tentity>(Tentity entity) where Tentity : class
        {
            _genericRepository.Add(_mappingService._mapper.Map<Tentity>(entity));
        }

        public async Task DeleteAsync<Tentity>(Tentity entity)
        {
            _genericRepository.Remove((_mappingService._mapper.Map<Tentity>(entity)));
            _genericRepository.SaveChanges();
        }

        public List<object> GetTentities(object entity)
        {

            return _genericRepository.Set<object>().ToList();
        }

        public async Task UpdateAsync<Tentity>(Tentity entity)
        {
            _genericRepository.Update(_mappingService._mapper.Map<Tentity>(entity));
        }
    }


}
