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

        public async Task<TeacherDTO> GetTeacherLogin(string email, string password, bool isadmin)
        {
            Teacher teacher = await _teacherRepository.GetTeacherLogin(email, password, isadmin);

            if (teacher != null)
            {
                TeacherDTO teacherdto = new(
                    teacher.Id,
                    teacher.Email,
                    teacher.password,
                    teacher.isadmin
                    );
                return teacherdto;
            }
            else
            return null;
        }
    }
}
