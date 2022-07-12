using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using CourseProjectRazor.Models.CarPageModel;

namespace CourseProjectRazor.Controllers
{
    public class CarPModel : PageModel
    {
		public CarPageModel thisPage { get; private set; }
        public void OnGet(string id)
        {
			thisPage = new CarPageModel(id);
		}
    }
}
