using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Services.DTO
{
    public class StudentDTO
    {
        public Guid Id { get; set; }
        public string Unilogin { get; set; }
        public string Password { get; set; }
        public StudentDTO(Guid id, string unilogin, string password) 
        {
        Id = id;
        Unilogin = unilogin;
        Password = password;
        
        } 
    }
}
