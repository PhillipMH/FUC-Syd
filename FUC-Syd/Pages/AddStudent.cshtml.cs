using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FUC_Syd.Pages
{
    public class AddStudentModel : PageModel
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string unilogin { get; set; }
        public string password { get; set; }
        public string password2 { get; set; }

        public void OnGet()
        {
        }
    }
}
