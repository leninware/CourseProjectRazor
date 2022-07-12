using System;
using System.Collections.Generic;
using CourseProjectRazor.Models.Cars;
using System.IO;

namespace CourseProjectRazor.Models.MainPageModel
{
	public class MainPageModel
	{
		public string dataPath { get; private set; }
		public List<Car> Cars { get; private set; }
		public MainPageModel()
		{
			dataPath = @"~/../wwwroot/Cars/Data/CarsData.txt";
			Cars = new List<Car>();
			StreamReader read = new StreamReader(dataPath);
			string line;
			while ((line = read.ReadLine()) != null)
				parseForCars(line);
		}
		private void parseForCars(string line)
		{
			string name = "", desc = "", img = "", id = "";
			int price = 0;
			int count = -1;
			string carLine = "";
			foreach (char ch in line)
			{
				// в базе данных каждый элемент информации фильма разделен
				// пробелом. При встрече пробела вызывается следующий блок кода
				if (ch == ' ' || ch == '\n')
				{
					count++;
					switch (count)
					{
						case 0: // номер машины
							id = carLine;
							break;
						case 1: // можель машины
							name = carLine.Replace('_', ' '); ;
							break;
						case 2: // цена 
							price = Convert.ToInt32(carLine);
							break;
						case 3: // описание
							desc = carLine.Replace('_', ' ');
							break;
						case 4: // изображение
							img = carLine;
							break;
					}
					carLine = "";
				}
				else carLine += ch;
			}
			Cars.Add(new Car(name, price, desc, img, carLine.Replace('_', ' '), id));
		}
	}
}
