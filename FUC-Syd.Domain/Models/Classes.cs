using System.ComponentModel.DataAnnotations;

namespace FUC_Syd.Domain.Models
{
    public class Classes
    {
        
        public Guid Id { get; set; }
        public string? ClassName { get; set; }
        public List<Student> students { get; set; } = null!;
        public Teacher teacher { get; set; } = null!;
    }
}