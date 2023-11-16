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
    public class CheckInRepository : GenericRepository<CheckIn>, ICheckInRepository
    {
        private readonly FUC_SydContext _dbcontext;

        public CheckInRepository(FUC_SydContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<CheckIn> Checkin(Student studentid, string name, DateTime time)
        {
            var checkin = await _dbcontext.CheckIn
    .SingleOrDefaultAsync(u => u.Student == studentid);

            if (checkin is not null)
            {
                return null;
            }
            var newCheckin = new CheckIn
            {
                Name = name,
                Time = time,
                Student = studentid

            };


            _dbcontext.CheckIn.Add(newCheckin);
                await _dbcontext.SaveChangesAsync();
                return newCheckin;
            
        }
        public async Task<List<CheckIn>> GetStudentsCheckedIn()
        {
            try
            {
                List<CheckIn> templist = await _dbcontext.CheckIn.Include(c => c.Student).ToListAsync();

                return templist;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while getting students.", ex);
            }
        }

    }
}
