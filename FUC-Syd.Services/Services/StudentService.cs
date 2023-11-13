using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUC_Syd.Services.Interfaces;
using FUC_Syd.Domain.Models;
using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Domain.Repositories;
using FUC_Syd.Services.DTO;

namespace FUC_Syd.Services.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository) : base()
        {
            _studentRepository = studentRepository;
        }


        public async Task<StudentDTO> GetStudentLogin(string email, string password)
        {
            Student student = await _studentRepository.GetStudentLogin(email, password);

            if (student != null)
            {
                StudentDTO studentdto = new(
                    student.Id,
                    student.unilogin,
                    student.password
                    );
                return studentdto;
            }
            else
                return null;
        }
    }
}
