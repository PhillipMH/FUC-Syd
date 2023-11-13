using Azure;
using FUC_Syd.Domain.Data;
using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Domain.Repositories
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository 
    {
        private readonly FUC_SydContext _dbcontext;

        public TeacherRepository(FUC_SydContext context) : base(context)
        {
            _dbcontext = context;
        }

        public async Task<Teacher> GetTeacherByIdAsync(Guid id)
        {
            return await _dbcontext.Teachers.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }
        public async Task<Teacher> GetTeacherLogin(string email, string password)
        {
            var teacher = await _dbcontext.Teachers
                .SingleOrDefaultAsync(u => u.Email == email && u.password == password);
            if (teacher != null) {
            return teacher;
            }
            else
            return null;
        }
    }
} 
