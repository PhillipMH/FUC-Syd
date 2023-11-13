using FUC_Syd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Domain.Interfaces
{
    public interface ITeacherRepository : IGenericRepository<Teacher>
    {
        Task<Teacher> GetTeacherByIdAsync(Guid id);
        Task<Teacher> GetTeacherLogin(string email, string password);
    }
}
