using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Domain.Models
{
    public class Student
    {
        
        public Guid Id { get; set; }
        public string unilogin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Phone { get; set; } = null!;
        public string password { get; set; } = null!;
        public bool isadmin { get; set; } = false;
        public Guid parents { get; set; }
        public List<Classes> classes { get; set; }
        public List<Grades> grades { get; set; } = null!;

    }
}
