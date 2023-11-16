using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUC_Syd.Domain.Models
{
    public class CheckIn
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public Student Student { get; set; }
    }
}
