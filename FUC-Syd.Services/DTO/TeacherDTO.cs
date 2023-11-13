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
        public TeacherDTO() { }
        public TeacherDTO(Guid id, string email, string password)
        {
            Id = id;
            Email = email;
            Password = password;
        }
    }
}
