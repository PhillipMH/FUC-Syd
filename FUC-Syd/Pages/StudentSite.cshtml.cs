using FUC_Syd.Domain.Models;
using FUC_Syd.Services.DTO;
using FUC_Syd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FUC_Syd.Pages
{
    public class StudentSiteModel : PageModel
    {
        private readonly ICheckInServices _genericservices;
        public StudentSiteModel(ICheckInServices genericservices)
        {
            _genericservices = genericservices;
        }

    }
}
