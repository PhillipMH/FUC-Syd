using FUC_Syd.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUC_Syd.Domain.Models;
using FUC_Syd.Services.DTO;

namespace FUC_Syd.Services.Interfaces
{
    public interface IStudentService
    {
        Task<StudentDTO>? GetStudentLogin(string unilogin, string password);
    }
}
