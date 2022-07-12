using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using CourseProjectRazor.Models.MainPageModel;
using System.IO;

namespace CourseProjectRazor.Controllers
{
	public class IndexModel : PageModel
	{
		public MainPageModel mainPModel { get; private set; }
		public void OnGet()
		{
			mainPModel = new MainPageModel();
		}
	}
}
