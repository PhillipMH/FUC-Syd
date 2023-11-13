using FUC_Syd.Services.DTO;
using FUC_Syd.Services.Interfaces;
using FUC_Syd.Services.SessionHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FUC_Syd.Pages
{

        public class StudentLogin : PageModel
        {
            private readonly IStudentService _Studentservices;
            public StudentLogin(IStudentService StudentServices) => _Studentservices = StudentServices;
            string successmessage = "";
            string errormessage = "";
            [BindProperty]
            public string? Status { get; set; }
            [BindProperty]
            public string Unilogin { get; set; }
            [BindProperty]
            public string Password { get; set; }
            [BindProperty]
            public Guid userid { get; set; }
            public async Task<IActionResult> OnPostLogin(string unilogin, string password)
            {
                if (ModelState.IsValid)
                {
                    StudentDTO? founduser = await _Studentservices.GetStudentLogin(unilogin.ToLower(), password);
                    if (founduser == null)
                    {
                        errormessage = "username or password was incorrect";
                    }
                    else if (Unilogin.ToLower() == founduser.Unilogin && Password == founduser.Password)
                    {
                        HttpContext.Session.SetSessionString(founduser.Unilogin, "unilogin");
                        return Page();
                    }
                }
                return RedirectToPagePermanent("Index", new { status = "ErrUser" });
            }

            public IActionResult OnPostLogOut()
            {
                HttpContext.Session.Remove("email");
                return Page();
            }

        }
    
}
