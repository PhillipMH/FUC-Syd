using FUC_Syd.Domain.Models;
using FUC_Syd.Services.DTO;
using FUC_Syd.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FUC_Syd.Pages
{
    public class TeacherSiteModel : PageModel
    {
        private readonly ICheckInServices _genericservices;
        public TeacherSiteModel(ICheckInServices genericservices, List<CheckInDTO> checkinlist)
        {
            _genericservices = genericservices;
            CheckIns = checkinlist;
        }
        public List<SickLeave>? SickLeaves { get; set; }
        public List<CheckInDTO>? CheckIns { get; set; }
        public async Task<IActionResult> OnGet()
        {
            var temp = await _genericservices.GetStudentsCheckedIn();
            foreach (var checkins in temp)
            {
                CheckIns.Add(checkins);
            }
            if (!string.IsNullOrWhiteSpace(HttpContext.Session.GetString("IsAdmin")))
            {
                return Page();
            }
            else if (!string.IsNullOrEmpty(HttpContext.Session.GetString("unilogin")) && string.IsNullOrEmpty(HttpContext.Session.GetString("IsAdmin")))
            {
                return RedirectToPage("/StudentSite");
            }
            else if (string.IsNullOrEmpty(HttpContext.Session.GetString("email")) && string.IsNullOrEmpty(HttpContext.Session.GetString("IsAdmin"))) { return RedirectToPage("/index"); }
            return null;
        }
    }
}
