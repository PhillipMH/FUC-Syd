using FUC_Syd.Domain.Models;
using FUC_Syd.Services.DTO;
using FUC_Syd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FUC_Syd.Pages
{
    public class AllStudentsModel : PageModel
    {
        
        public List<StudentDTO> StudentList = new List<StudentDTO>();
        private readonly IStudentService _genericservices;
        public AllStudentsModel(IStudentService genericservices, List<StudentDTO> studentlist)
        {
            StudentList = studentlist;
            _genericservices = genericservices;
        }

        public async void OnGet()
        {
            var temp = await _genericservices.GetAllStudents();
            foreach (var student in temp)
            {
                StudentList.Add(student);

            }
        }
    }
}
