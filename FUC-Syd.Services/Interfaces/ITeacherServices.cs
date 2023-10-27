using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Services.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Services.Interfaces
{
    public interface ITeacherServices : IGenericRepository<TeacherDTO>
    {
        Task<TeacherDTO> GetTeacherAsync(Guid id);
        Task<TeacherDTO> GetTeacherLogin(string email, string password);
    }
}
