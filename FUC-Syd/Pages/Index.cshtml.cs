using FUC_Syd.Services.Interfaces;
using FUC_Syd.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using FUC_Syd.Services.DTO;
using FUC_Syd.Services.SessionHelper;
using Azure.Identity;

namespace FUC_Syd.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ITeacherServices _teacherservices;
        public IndexModel(ITeacherServices teacherServices) => _teacherservices = teacherServices;

        string successmessage = "";
        string errormessage = "";
        public string? Status { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public Guid userid { get; set; }
        public bool IsAdmin { get; } = true;
        public async Task<IActionResult> OnPostLogin(string email, string password, bool isadmin)
        {
        if (ModelState.IsValid)
            {
                TeacherDTO? founduser = await _teacherservices.GetTeacherLogin(email.ToLower(), password, isadmin);
                if (founduser == null)
                {
                    errormessage = "username or password was incorrect";
                }
                else if (Email.ToLower() == founduser.Email && Password == founduser.Password)
                {
                    HttpContext.Session.SetSessionString(founduser.Email, "email");
                    HttpContext.Session.SetSessionString(founduser.IsAdmin.ToString(), "isadmin");
                    return RedirectToPage("/TeacherSite");
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
