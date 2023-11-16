using FUC_Syd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Services.DTO
{
    public class CheckInDTO
    {
        public Guid Id { get; set; }
        public Student StudentId { get; set; }  
        public string Name { get; set; }
        public DateTime Time { get; set; }

        public CheckInDTO(Guid id, Student Student, string name, DateTime time)
        {
            Id = id;
            StudentId = Student;
            Name = name;
            Time = time;
        }
    }

}

