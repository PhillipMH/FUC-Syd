using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Services.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUC_Syd.Domain.Models;

namespace FUC_Syd.Services.Interfaces
{
    public interface IStudentService : IGenericRepository<StudentDTO>
    {
    }
}
