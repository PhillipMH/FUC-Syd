using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Domain.Models
{
    public class Grades
    {
        public Guid Id { get; set; }
        public Student stu_fullname { get; set; } = null!;
        public int grade { get; set; }
        public Classes classid { get; set; } = null!;
        public string teacher { get; set; } = null!;
    }
}
