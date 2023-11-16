using FUC_Syd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Domain.Interfaces
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<Student> GetStudentLogin(string unilogin, string password);
        Task<Student> AddStudent(Guid id, string firstname, string lastname, string unilogin, string password);
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentById(Guid id);
        Task<Student> DeleteStudentById(Guid id);
        Task<Student> UpdateStudent(Student updatedStudent);
    }
}
