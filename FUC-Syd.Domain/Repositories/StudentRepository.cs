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
    }
}
