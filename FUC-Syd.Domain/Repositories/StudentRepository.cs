using FUC_Syd.Domain.Data;
using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Domain.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        private readonly FUC_SydContext _dbcontext;

        public StudentRepository(FUC_SydContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<Student> GetStudentLogin(string unilogin, string password)
        {
            var student = await _dbcontext.Students
                .SingleOrDefaultAsync(u => u.unilogin == unilogin && u.password == password);
            if (student != null)
            {
                return student;
            }
            else
                return null;
        }
        public async Task<Student> AddStudent(Guid id, string firstname, string lastname, string unilogin, string password)
        {
            var existingStudent = await _dbcontext.Students
                .SingleOrDefaultAsync(u => u.unilogin == unilogin);

            if (existingStudent != null)
            {
                return null;
            }

            var newStudent = new Student
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                unilogin = unilogin,
                password = password
            };
            _dbcontext.Students.Add(newStudent);
            await _dbcontext.SaveChangesAsync();
            return newStudent;
        }
        public async Task<List<Student>> GetAllStudents()
        {
            List<Student> templist = new List<Student>();
            try
            {
                foreach (var student in _dbcontext.Students)
                {
                    templist.Add(student);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while getting students.", ex);
            }
            return templist;
        }
        public async Task<Student> GetStudentById(Guid id)
        {
            var student = await _dbcontext.Students
               .SingleOrDefaultAsync(u => u.Id == id);
            if (student is not null)
            {
                return student;
            }
            else
                return null;
        }
        public async Task<Student> DeleteStudentById(Guid id)
        {
            var temp = await _dbcontext.Students
                .SingleOrDefaultAsync (u => u.Id == id);
            if (temp is not null)
            {
                _dbcontext.Remove(temp);
                await _dbcontext.SaveChangesAsync();
            }
            return null;
        }
        public async Task<Student> UpdateStudent(Student updatedStudent)
        {
            var existingStudent = await _dbcontext.Students.FindAsync(updatedStudent.Id);

            if (existingStudent != null)
            {
               
                existingStudent.FirstName = updatedStudent.FirstName;
                existingStudent.LastName = updatedStudent.LastName;
                existingStudent.password = updatedStudent.password;
                existingStudent.Phone = updatedStudent.Phone;
                existingStudent.parents = updatedStudent.parents;

               
                await _dbcontext.SaveChangesAsync();

                return existingStudent;
            }

           
            return null;
        }

    }
}
