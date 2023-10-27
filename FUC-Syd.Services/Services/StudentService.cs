using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUC_Syd.Services.DataTransferObjects;
using FUC_Syd.Services.Interfaces;
using FUC_Syd.Domain.Models;
using FUC_Syd.Domain.Interfaces;

namespace FUC_Syd.Services.Services
{
    public class StudentService : GenericService<StudentDTO, IStudentRepository, Student>, IStudentService
    {
        private readonly MappingService _mappingService;
        private readonly IStudentRepository _studentRepository;

        public StudentService(MappingService mappingService, IStudentRepository studentRepository) : base(mappingService,studentRepository)
        {
            _mappingService = mappingService;
            _studentRepository = studentRepository;
        }
    }
}
