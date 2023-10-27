using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Domain.Models;
using FUC_Syd.Services.DataTransferObjects;
using FUC_Syd.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Services.Services
{
    public class TeacherService : GenericService<TeacherDTO, ITeacherRepository, Teacher>, ITeacherServices
    {
        private readonly MappingService _mappingService;
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(MappingService mappingService, ITeacherRepository teacherRepository) : base(mappingService, teacherRepository)
        {
            _mappingService = mappingService;
            _teacherRepository = teacherRepository;
        }

        public async Task<TeacherDTO> GetTeacherAsync(Guid id)
        {
            return _mappingService._mapper.Map<TeacherDTO>(await _teacherRepository.GetTeacherByIdAsync(id));
        }

        public async Task<TeacherDTO> GetTeacherLogin(string username, string password)
        {
            return _mappingService._mapper.Map<TeacherDTO>(await _teacherRepository.GetLogin(username, password));
        }
    }
}
