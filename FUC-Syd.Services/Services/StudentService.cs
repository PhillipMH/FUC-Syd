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
                StudentDTO studentdto = new StudentDTO(
                    student.Id,
                    student.unilogin,
                    student.password,
                    student.FirstName = null,
                    student.LastName = null
                    );
                return studentdto;
            }
            else
                return null;
        }
        public async Task<StudentDTO> AddStudent(Guid id, string firstname, string lastname, string unilogin, string password)
        {
            Student addedStudent = await _studentRepository.AddStudent(id, firstname, lastname, unilogin, password);
            if (addedStudent == null) 
            {
                return null;
            }
            return null;
        }
        public async Task<List<StudentDTO>> GetAllStudents()
        {
            List<Student> dbuserlist = await _studentRepository.GetAllStudents();
            List<StudentDTO> userlist = new();
            if (dbuserlist is not null)
            {
                dbuserlist.ForEach(x => userlist.Add(new StudentDTO(
                x.Id,
                x.unilogin,
                x.FirstName,
                x.LastName,
                x.password = null
            )));
                return userlist;

            }
            return null;
        }
        public async Task<StudentDTO> GetStudentById(Guid id)
        {
            Student student = await _studentRepository.GetStudentById(id);

            if (student != null)
            {
                StudentDTO studentdto = new StudentDTO(
                    student.Id,
                    student.unilogin,
                    student.password,
                    student.FirstName,
                    student.LastName
                );
                return studentdto;
            }
            else
            {
                return null;
            }
        }
        public async Task<StudentDTO> DeleteStudentById(Guid id)
        {
            Student student = await _studentRepository.DeleteStudentById(id);

            if (student is not null ) 
            {
            _studentRepository.DeleteStudentById(student.Id);
            }
            return null;
        }
        public async Task<StudentDTO> UpdateStudent(Student updatedStudent)
        {
            updatedStudent = await _studentRepository.UpdateStudent(updatedStudent);

            if (updatedStudent is not null)
            {
                _studentRepository.UpdateStudent(updatedStudent);
            }
            return null;
        }

    }
}
