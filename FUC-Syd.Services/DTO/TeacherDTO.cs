using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Services.DTO
{
    public class TeacherDTO
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsAdmin { get; set; }
        public TeacherDTO() { }
        public TeacherDTO(Guid id, string email, string password, bool isadmin)
        {
            IsAdmin = isadmin;
            Id = id;
            Email = email;
            Password = password;
        }
    }
}
