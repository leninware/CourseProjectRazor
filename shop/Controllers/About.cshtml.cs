using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using CourseProjectRazor.Models.AboutPageModel;

namespace CourseProjectRazor.Controllers
{
    public class AboutModel : PageModel
    {
        public AboutPageModel aboutP { get; private set; }
        public void OnGet()
        {
            aboutP = new AboutPageModel();
        }
    }
}