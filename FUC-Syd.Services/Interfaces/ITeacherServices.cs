using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUC_Syd.Services.DTO;


namespace FUC_Syd.Services.Interfaces
{
    public interface ITeacherServices
    {
        Task<Teacher> GetTeacherAsync(Guid id);
        Task<TeacherDTO>? GetTeacherLogin(string email, string password);
    }
}
