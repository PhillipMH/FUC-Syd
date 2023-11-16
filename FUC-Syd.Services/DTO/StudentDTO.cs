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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; } = false; // Add setter and default value

        public StudentDTO(Guid id, string unilogin, string firstname, string lastname, string password)
        {
            Id = id;
            Unilogin = unilogin;
            FirstName = firstname;
            LastName = lastname;
            Password = password;
        }
    }
}
