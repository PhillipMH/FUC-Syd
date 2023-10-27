using FUC_Syd.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Domain.Repositories
{
    internal class StudentRepository
    {
        private readonly FUC_SydContext _dbcontext;

        protected StudentRepository(FUC_SydContext dbcontex)
        {
            _dbcontext = dbcontex;
        }
    }
}
