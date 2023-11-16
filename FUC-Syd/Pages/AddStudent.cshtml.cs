using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Services.DTO;
using FUC_Syd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;

namespace FUC_Syd.Pages
{
    public class AddStudentModel : PageModel
    {
        private readonly IStudentService _genericservices;
        public AddStudentModel(IStudentService genericservices)
        {
            _genericservices = genericservices;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UniLogin { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public async Task<IActionResult> OnPost(string firstname, string lastname, string unilogin, string password)
        {
            if (_genericservices is not null)
            {
                //var temp = new StudentDTO
                //{
                //Guid Id = Guid.NewGuid(),
                //    firstname = firstname,
                //    lastname = lastname,
                //    Unilogin = unilogin,
                //    Password = password

                //};

                Guid id = Guid.NewGuid();
            await _genericservices.AddStudent(id, firstname, lastname, unilogin, password);
            }
            else
            {
            return RedirectToPage();

            }
            return null;
        }



    }
}
