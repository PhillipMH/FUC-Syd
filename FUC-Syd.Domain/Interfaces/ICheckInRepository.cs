using FUC_Syd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Domain.Interfaces
{
    public interface ICheckInRepository : IGenericRepository<CheckIn>
    {
        Task<CheckIn> Checkin(Student Id, string name, DateTime time);
        Task<List<CheckIn>> GetStudentsCheckedIn();
    }
}
