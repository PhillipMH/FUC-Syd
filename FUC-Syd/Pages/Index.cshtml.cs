using FUC_Syd.Domain.Interfaces;
using FUC_Syd.Services.DataTransferObjects;
using FUC_Syd.Services.Interfaces;
using FUC_Syd.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FUC_Syd.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITeacherServices _teacherservices;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        string successmessage = "";
        string errormessage = "";
        [BindProperty]
        public string username { get; set; }
        [BindProperty]
        public string password { get; set; }
        public Guid userid { get; set; }
    }
}
