using FUC_Syd.Domain.Models;
using FUC_Syd.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Services.Interfaces
{
    public interface ICheckInServices
    {
        Task<StudentDTO> Checkin(Student Id, string name, DateTime time);
        Task<List<CheckInDTO>> GetStudentsCheckedIn();
    }
}
