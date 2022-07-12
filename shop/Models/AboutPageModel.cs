using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CourseProjectRazor.Models.AboutPageModel
{
	public class AboutPageModel
	{
		public string aboutText { get; private set; } 
		// Текст-информация о сайте
		public AboutPageModel()
		{
			StreamReader read = new StreamReader(@"~/../wwwroot/AboutText.txt");
			aboutText = read.ReadToEnd();
		}
	}
}
