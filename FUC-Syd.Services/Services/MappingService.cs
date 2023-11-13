using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Domain.Models;
using FUC_Syd.Services.DTO;

namespace FUC_Syd.Services.Services
{
    public class MappingService
    {
        private readonly ITeacherRepository _teacherRepository;
        public readonly AutoMapper.IMapper _mapper;
        public MappingService()
        {
            AutoMapper.MapperConfiguration config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Teacher, TeacherDTO>();
                cfg.CreateMap<TeacherDTO, Teacher>();
                cfg.CreateMap<Student, StudentDTO>();
                cfg.CreateMap<StudentDTO, Student>();
            });

            try
            {
                _mapper = config.CreateMapper();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"failed to create map {ex.Message}");
            }
        }
        public TeacherDTO MapTeacherToDTO(Teacher teacher)
        {
            return _mapper.Map<TeacherDTO>(teacher);
        }
        public StudentDTO MapStudentToDTO(Student student)
        {
            return _mapper.Map<StudentDTO>(student);
        }

    }
}
