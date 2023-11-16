using System;
using System.Threading.Tasks;
using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Domain.Models;
using FUC_Syd.Services.DTO;
using FUC_Syd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FUC_Syd.Pages
{
    public class EditStudentModel : PageModel
    {
        private readonly IStudentService _studentRepository; // Assuming you have a repository for managing students

        public EditStudentModel(IStudentService studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public  string password { get; set; }
        public StudentDTO Student { get; set; }
        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                return RedirectToPage("/Error");
            }
            var student = await _studentRepository.GetStudentById(id);
            student.FirstName = firstname;
            student.LastName = lastname;
            student.Password = password;

            if (student != null)
            {
                return Page();
            }
            return null;
        }

        public async Task<IActionResult> OnPostSaveAsync(Student student)
        {
            // Validate the model state
            if (!ModelState.IsValid)
            {
                return Page();
            }
            

            // Update the student details in the repository
            Student = await _studentRepository.UpdateStudent(student);

            // Redirect to a success page or the student list page
            return RedirectToPage("StudentList");
        }

        public async Task<IActionResult> OnPostDeleteAsync(Guid studentId)
        {
            // Delete the student from the repository based on the provided ID
            _studentRepository.DeleteStudentById(studentId);

            // Redirect to a success page or the student list page
            return RedirectToPage("AllStudents");
        }
    }

}
