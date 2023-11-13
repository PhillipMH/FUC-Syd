using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Domain.Models;
using FUC_Syd.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUC_Syd.Services.DTO;
using AutoMapper;
using Azure;

namespace FUC_Syd.Services.Services
{
    public class TeacherService : ITeacherServices
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task<Teacher> GetTeacherAsync(Guid id)
        {
            return await _teacherRepository.GetTeacherByIdAsync(id);
        }

        public async Task<TeacherDTO> GetTeacherLogin(string email, string password)
        {
            Teacher teacher = await _teacherRepository.GetTeacherLogin(email, password);

            if (teacher != null)
            {
                TeacherDTO teacherdto = new(
                    teacher.Id,
                    teacher.Email,
                    teacher.password
                    );
                return teacherdto;
            }
            else
            return null;
        }
    }
}
