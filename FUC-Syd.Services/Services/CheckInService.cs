using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Domain.Models;
using FUC_Syd.Domain.Repositories;
using FUC_Syd.Services.DTO;
using FUC_Syd.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Services.Services
{
    public class CheckInService : ICheckInServices
    {
        private readonly ICheckInRepository _checkinRepository;

        public CheckInService(ICheckInRepository checkinRepository) : base()
        {
            _checkinRepository = checkinRepository;
        }

        public async Task<StudentDTO> Checkin(Student checkinstudent, string name, DateTime time)
        {
            CheckIn addstudentcheckin = await _checkinRepository.Checkin(checkinstudent, name, time );
            if (addstudentcheckin != null)
            {
                return null;
            }
            else
                return null;
        }
        public async Task<List<CheckInDTO>> GetStudentsCheckedIn()
        {
            List<CheckIn> dbCheckInList = await _checkinRepository.GetStudentsCheckedIn();
            List<CheckInDTO> checkInList = new List<CheckInDTO>();

            if (dbCheckInList is not null)
            {
                dbCheckInList.ForEach(x => checkInList.Add(new CheckInDTO(
                    x.Id,
                    x.Student,
                    x.Name,
                    x.Time
                )));
                return checkInList;
            }

            return null;
        }


    }
}
